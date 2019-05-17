Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmSchedules

    Dim mSchedule_ID As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mSchedule_ID = 0
        txtDescription.Text = ""
        txt1st_insched.Value = vbNull
        txt1st_outsched.Value = vbNull
        txt2nd_insched.Value = vbNull
        txt2nd_outsched.Value = vbNull
        txt3rd_insched.Value = vbNull
        txt3rd_outsched.Value = vbNull

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim dtSchedules As New DataTable
            If NetOpen(dtSchedules, "select * from schedules where schedule_id=" & mSearchID) = True Then
                If dtSchedules.Rows.Count > 0 Then
                    Call Clear_Fields()
                    For Each drSchedule As DataRow In dtSchedules.Rows
                        mSchedule_ID = mSearchID
                        txtDescription.Text = CType(drSchedule.Item("description"), String)
                        txt1st_insched.Value = CType(drSchedule.Item("1st_insched"), TimeSpan)
                        txt1st_outsched.Value = CType(drSchedule.Item("1st_outsched"), TimeSpan)
                        If Not IsDBNull(drSchedule.Item("2nd_insched")) Then
                            txt2nd_insched.Value = CType(drSchedule.Item("2nd_insched"), TimeSpan)
                        End If
                        If Not IsDBNull(drSchedule.Item("2nd_outsched")) Then
                            txt2nd_outsched.Value = CType(drSchedule.Item("2nd_outsched"), TimeSpan)
                        End If
                        If Not IsDBNull(drSchedule.Item("3rd_insched")) Then
                            txt3rd_insched.Value = CType(drSchedule.Item("3rd_insched"), TimeSpan)
                        End If
                        If Not IsDBNull(drSchedule.Item("3rd_outsched")) Then
                            txt3rd_outsched.Value = CType(drSchedule.Item("3rd_outsched"), TimeSpan)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        btnSave.Enabled = False

        Dim mTransLock As MySqlTransaction
        Dim mCmdLock As New MySqlCommand
        Dim rdQuery As MySqlDataReader

        Dim mTrans As MySqlTransaction
        Dim mCommand As New MySqlCommand

        Dim fs As New MemoryStream()

        Dim m1stin As String = "Null"
        Dim m1stout As String = "Null"
        Dim m2ndin As String = "Null"
        Dim m2ndout As String = "Null"
        Dim m3rdin As String = "Null"
        Dim m3rdout As String = "Null"

        Dim mIncompleteSched As Boolean = False

        If Trim(txtDescription.Text) = "" Then
            MsgBox("Please specify the description.", MsgBoxStyle.Information)
            txtDescription.Focus()
            btnSave.Enabled = True
            Exit Sub
        End If

        If Trim(txt1st_outsched.Text) <> "" Then
            If Trim(txt1st_insched.Text) <> "" Then
                m1stin = "'" & Format(txt1st_insched.Value, "HH:mm:00") & "'"
                m1stout = "'" & Format(txt1st_outsched.Value, "HH:mm:00") & "'"
                If Trim(txt2nd_outsched.Text) <> "" Then
                    If Trim(txt2nd_insched.Text) <> "" Then
                        m2ndin = "'" & Format(txt2nd_insched.Value, "HH:mm:00") & "'"
                        m2ndout = "'" & Format(txt2nd_outsched.Value, "HH:mm:00") & "'"
                        If Trim(txt3rd_outsched.Text) <> "" Then
                            If Trim(txt3rd_insched.Text) <> "" Then
                                m3rdin = "'" & Format(txt3rd_insched.Value, "HH:mm:00") & "'"
                                m3rdout = "'" & Format(txt3rd_outsched.Value, "HH:mm:00") & "'"
                            Else
                                mIncompleteSched = True
                            End If
                        Else
                            If Trim(txt3rd_insched.Text) <> "" Then
                                mIncompleteSched = True
                            End If
                        End If
                    Else
                        mIncompleteSched = True
                    End If
                Else
                    If Trim(txt2nd_insched.Text) <> "" Then
                        mIncompleteSched = True
                    Else
                        If Trim(txt3rd_insched.Text) <> "" Or Trim(txt3rd_outsched.Text) <> "" Then
                            mIncompleteSched = True
                        End If
                    End If
                End If
            Else
                mIncompleteSched = True
            End If
        Else
            'If Trim(txt1st_insched.Text) <> "" Then
            mIncompleteSched = True
            'Else
            '    If Trim(txt2nd_insched.Text) <> "" Or Trim(txt2nd_outsched.Text) <> "" Or Trim(txt3rd_insched.Text) <> "" Or Trim(txt3rd_outsched.Text) <> "" Then
            '        mIncompleteSched = True
            '    End If
            'End If
        End If

        If mIncompleteSched Then
            MsgBox("Please check for incomplete schedule settings.", MsgBoxStyle.Information)
            btnSave.Enabled = True
            Exit Sub
        End If

        mTrans = Cn.Connection.BeginTransaction
        mTransLock = cnLock.Connection.BeginTransaction

        Try
            mCmdLock.Transaction = mTransLock
            mCmdLock.Connection = cnLock.Connection
            mCmdLock.CommandText = "LOCK TABLES trans_lock WRITE"
            mCmdLock.ExecuteNonQuery()

            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection

            If mSchedule_ID = 0 Then
                mCommand.CommandText = "select description from schedules where description=@description"
            Else
                mCommand.CommandText = "select description from schedules where description=@description and schedule_id <> @schedule_id"
                mCommand.Parameters.AddWithValue("@schedule_id", mSchedule_ID)
            End If
            mCommand.Parameters.AddWithValue("@description", txtDescription.Text)
            rdQuery = mCommand.ExecuteReader
            If rdQuery.HasRows Then
                rdQuery.Close()
                mTrans.Rollback()
                mCommand.Dispose()
                mTrans.Dispose()
                mCmdLock.CommandText = "UNLOCK TABLES"
                mCmdLock.ExecuteNonQuery()
                mCmdLock.Dispose()
                mTransLock.Rollback()
                mCmdLock.Dispose()
                mTransLock.Dispose()
                MsgBox("Duplicate description found.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
                btnSave.Enabled = True
                txtDescription.Focus()
                Exit Sub
            Else
                rdQuery.Close()
            End If
            If mSchedule_ID = 0 Then
                mCommand.CommandText = "insert into schedules (description,1st_insched,1st_outsched,2nd_insched,2nd_outsched,3rd_insched,3rd_outsched) values " & _
                                   "(@description," & m1stin & "," & m1stout & "," & m2ndin & "," & m2ndout & "," & m3rdin & "," & m3rdout & ")"
            Else
                mCommand.CommandText = "update schedules set description=@description," & _
                                   "1st_insched=" & m1stin & ",1st_outsched=" & m1stout & ", " & _
                                   "2nd_insched=" & m2ndin & ",2nd_outsched=" & m2ndout & ", " & _
                                   "3rd_insched=" & m3rdin & ",3rd_outsched=" & m3rdout & " " & _
                                   "where schedule_id=@schedule_id"
            End If
            mCommand.ExecuteNonQuery()
            If mSchedule_ID = 0 Then
                mSchedule_ID = CType(mCommand.LastInsertedId, Integer)
                mCommand.Parameters.AddWithValue("@schedule_id", mSchedule_ID)
            End If

            mTrans.Commit()

            mCmdLock.CommandText = "UNLOCK TABLES"
            mCmdLock.ExecuteNonQuery()
            mCmdLock.Dispose()
            mTransLock.Rollback()
            mCmdLock.Dispose()
            mTransLock.Dispose()

            MsgBox("Information has been succesfully saved!", MsgBoxStyle.Information)
            txtDescription.Focus()
        Catch ex As MySqlException
            If Not (mTrans Is Nothing) Then
                mTrans.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            If Not (mTrans Is Nothing) Then
                mTrans.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Try
                mCommand.Dispose()
                mTrans.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                btnSave.Enabled = True
            End Try
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If mSchedule_ID = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to define new schedule?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call Clear_Fields()
    End Sub

End Class