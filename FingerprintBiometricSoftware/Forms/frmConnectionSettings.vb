Imports MySql.Data.MySqlClient

Public Class frmConnectionSettings

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Cn = Nothing
        Cn = New clsConnectionDetails
        If Trim(txtServerName.Text) = "" Then
            MsgBox("Please specify server.", MsgBoxStyle.Information)
            txtServerName.Focus()
            Exit Sub
        End If
        If Trim(txtUsername.Text) = "" Then
            MsgBox("Please specify user name.", MsgBoxStyle.Information)
            txtUsername.Focus()
            Exit Sub
        End If
        If Trim(txtPassword.Text) = "" Then
            MsgBox("Please provide a password.", MsgBoxStyle.Information)
            txtPassword.Focus()
            Exit Sub
        End If
        If Trim(txtPort.Text) = "" Then
            MsgBox("Please specify port.", MsgBoxStyle.Information)
            txtPort.Focus()
            Exit Sub
        End If
        If IsDBNull(cboDatabase.SelectedValue) Or Trim(cboDatabase.Text) = "" Then
            MsgBox("Please select database.", MsgBoxStyle.Information)
            cboDatabase.Focus()
            Exit Sub
        End If
        Cn.ConnectToServer(ConSwap(txtServerName.Text), ConSwap(txtUsername.Text), ConSwap(txtPassword.Text), ConSwap(txtPort.Text), ConSwap(cboDatabase.Text))
        If Cn.IsConnected Then
            Cn.EncodeCredentials()
            cnLock = Nothing
            cnLock = New clsConnectionDetails
            cnLock.ConnectToServer()
            Call Close()
        End If
    End Sub

    Private Sub TestConnection()
        Dim mCon As New MySqlConnection
        Dim mCommand As New MySqlCommand
        Dim mReader As MySqlDataReader
        Try
            mCon.ConnectionString = "Server=" & ConSwap(txtServerName.Text) & ";" _
                & "Uid=" & ConSwap(txtUsername.Text) & ";" _
                & "Pwd=" & ConSwap(txtPassword.Text) & ";" _
                & "Port=" & ConSwap(txtPort.Text) & ""
            mCon.Open()
            Try
                mCommand.Connection = mCon
                mCommand.CommandText = "show schemas"
                mReader = mCommand.ExecuteReader
                While mReader.Read
                    cboDatabase.AddItem(CType(mReader.GetValue(mReader.GetOrdinal("database")), String))
                End While
                mReader.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                txtServerName.Focus()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            txtServerName.Focus()
        End Try
        mCon.Close()
        mCon.Dispose()
        mCommand.Dispose()
    End Sub

    Private Sub frmConnectionSettings_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtServerName.Text = Cn.Host
        txtUsername.Text = Cn.Username
        txtPort.Text = Cn.Port
    End Sub

    Private Sub cboDatabase_Open(sender As Object, e As System.EventArgs) Handles cboDatabase.Open
        cboDatabase.Text = ""
        cboDatabase.ClearItems()
        Call TestConnection()
    End Sub

End Class