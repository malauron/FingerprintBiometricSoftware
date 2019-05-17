Imports MySql.Data.MySqlClient

Public Class frmSecurityVerification

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        btnOK.Enabled = False
        Dim mConnectionSuccessfull As Boolean = False
        Try
            Dim mCommand As New MySqlCommand
            Dim mReader As MySqlDataReader
            If Cn.IsConnected = True Then
                mCommand.Connection = Cn.Connection
                mCommand.CommandText = "select a.* from users a " & _
                                       "where a.username = @username and a.user_password = password(@password)"
                mCommand.Parameters.AddWithValue("@username", txtUsername.Text)
                mCommand.Parameters.AddWithValue("@password", txtPassword.Text)
                mReader = mCommand.ExecuteReader
                If mReader.HasRows Then
                    While mReader.Read
                        User.UserID = CType(mReader.Item("user_id"), String)
                        User.Fullname = CStr(mReader.Item("fullname"))
                        User.Username = CStr(mReader.Item("username"))
                        User.Menu_User = CType(mReader.Item("mnu_user"), Integer)
                        User.Menu_Employee_Info = CType(mReader.Item("mnu_employee_info"), Integer)
                        User.Menu_Schedules = CType(mReader.Item("mnu_schedules"), Integer)
                        User.Menu_Cutoff_Periods = CType(mReader.Item("mnu_cutoff_periods"), Integer)
                        User.Menu_Assign_Schedules = CType(mReader.Item("mnu_assign_schedules"), Integer)
                        User.Menu_Generate_DTR = CType(mReader.Item("mnu_generate_dtr"), Integer)
                        User.Menu_DTR_Adjustments = CType(mReader.Item("mnu_dtr_adjustments"), Integer)
                        User.Menu_Print_DTR = CType(mReader.Item("mnu_print_dtr"), Integer)
                    End While
                    mConnectionSuccessfull = True
                Else
                    MsgBox("Either username or password is not correct.", MsgBoxStyle.Exclamation, "Invalid account.")
                End If
                mReader.Close()
            Else
                MsgBox("Connection to database was not successful.", MsgBoxStyle.Exclamation, "Connection status.")
            End If
            mReader = Nothing
            mCommand.Dispose()
            mCommand = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If Not mConnectionSuccessfull Then
                btnOK.Enabled = True
            Else
                Call Hide()
                Dim mForm As Form
                mForm = New frmAdminTasks
                mForm.ShowDialog()
                mForm.Dispose()
            End If
        End Try
    End Sub
End Class