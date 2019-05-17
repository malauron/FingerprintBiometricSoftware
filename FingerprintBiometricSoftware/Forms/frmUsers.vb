Imports MySql.Data.MySqlClient

Public Class frmUsers

    Dim mUser_ID As Integer

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If mUser_ID > 0 Then
            If MsgBox("Do you want to create another user?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then
                Call Clear_Fields()
            End If
        End If
    End Sub

    Private Sub Clear_Fields()
        mUser_ID = 0
        btnShowResetPassword.Visible = False
        txtUsername.ReadOnly = False
        txtUser_Password.Visible = True
        txtConfirm.Visible = True
        lblPassword.Visible = True
        lblConfirm.Visible = True
        txtFullname.Text = ""
        txtUsername.Text = ""
        txtUser_Password.Text = ""
        chkMnu_Users.Checked = False
        chkMnu_Employee_Info.Checked = False
        chkMnu_Schedules.Checked = False
        chkMnu_Cutoff_Periods.Checked = False
        chkMnu_Assign_Schedules.Checked = False
        chkMnu_Generate_DTR.Checked = False
        chkMnu_DTR_Adjustments.Checked = False
        chkMnu_Print_DTR.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If Trim(txtFullname.Text) = "" Then
            MsgBox("Fullname field is blank.", MsgBoxStyle.Exclamation)
            txtFullname.Focus()
            Exit Sub
        End If

        If Trim(txtUsername.Text) = "" Then
            MsgBox("Username field is blank.", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
            Exit Sub
        End If


        If Trim(txtUser_Password.Text) = "" And mUser_ID = 0 Then
            MsgBox("Password field is blank.", MsgBoxStyle.Exclamation)
            txtUser_Password.Focus()
            Exit Sub
        End If

        If (Trim(txtUser_Password.Text) <> Trim(txtConfirm.Text)) And mUser_ID = 0 Then
            MsgBox("Passwords don't match.", MsgBoxStyle.Exclamation)
            txtConfirm.Focus()
            Exit Sub
        End If

        Try
            Dim mTrans As MySqlTransaction
            Dim mCommand As New MySqlCommand
            Dim mCmdChk As New MySqlCommand
            Dim rdPromoCtr As MySqlDataReader

            mTrans = Cn.Connection.BeginTransaction
            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection
            mCmdChk.Connection = Cn.Connection

            If mUser_ID = 0 Then

                mCmdChk.CommandText = "select username from users where username = @username"
                mCmdChk.Parameters.AddWithValue("@username", txtUsername.Text)
                rdPromoCtr = mCmdChk.ExecuteReader

                If rdPromoCtr.HasRows Then
                    MsgBox("Username already in use!", MsgBoxStyle.Exclamation)
                    mTrans.Rollback()
                    mTrans.Dispose()
                    rdPromoCtr.Close()
                    Exit Sub
                Else
                    rdPromoCtr.Close()
                End If

                mCommand.CommandText = "insert into users (fullname,username,user_password," & _
                                        "mnu_user,mnu_employee_info,mnu_schedules,mnu_cutoff_periods," & _
                                        "mnu_assign_schedules,mnu_generate_dtr,mnu_dtr_adjustments,mnu_print_dtr) values " & _
                                        "(@fullname,@username,password(@user_password)," & _
                                        "@mnu_user,@mnu_employee_info,@mnu_schedules,@mnu_cutoff_periods," & _
                                        "@mnu_assign_schedules,@mnu_generate_dtr,@mnu_dtr_adjustments,@mnu_print_dtr)"
                mCommand.Parameters.AddWithValue("@username", txtUsername.Text)
                mCommand.Parameters.AddWithValue("@user_password", txtUser_Password.Text)

            Else
                mCommand.CommandText = "update users set fullname=@fullname,mnu_user=@mnu_user,mnu_employee_info=@mnu_employee_info,mnu_schedules=@mnu_schedules," & _
                                        "mnu_cutoff_periods=@mnu_cutoff_periods,mnu_assign_schedules=@mnu_assign_schedules, " & _
                                        "mnu_generate_dtr=@mnu_generate_dtr,mnu_dtr_adjustments=@mnu_dtr_adjustments," & _
                                        "mnu_print_dtr=@mnu_print_dtr " & _
                                        "where user_id = @user_id"
                mCommand.Parameters.AddWithValue("@user_id", mUser_ID)
            End If

            mCommand.Parameters.AddWithValue("@fullname", txtFullname.Text)
            mCommand.Parameters.AddWithValue("@mnu_user", CType(chkMnu_Users.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_employee_info", CType(chkMnu_Employee_Info.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_schedules", CType(chkMnu_Schedules.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_cutoff_periods", CType(chkMnu_Cutoff_Periods.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_assign_schedules", CType(chkMnu_Assign_Schedules.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_generate_dtr", CType(chkMnu_Generate_DTR.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_dtr_adjustments", CType(chkMnu_DTR_Adjustments.Checked, Integer))
            mCommand.Parameters.AddWithValue("@mnu_print_dtr", CType(chkMnu_Print_DTR.Checked, Integer))
            mCommand.ExecuteNonQuery()

            If mUser_ID = 0 Then
                mUser_ID = CType(mCommand.LastInsertedId, Integer)
            Else
            End If

            mTrans.Commit()
            mTrans.Dispose()
            If MsgBox("Information has been succesfully saved!" & vbCrLf & "Do you want to create new user?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                Call Clear_Fields()
            Else
                txtUsername.ReadOnly = True
                txtUser_Password.Visible = False
                txtConfirm.Visible = False
                lblPassword.Visible = False
                lblConfirm.Visible = False
                'txtConfirmPassword.Visible = False
                'lblPassword.Visible = False
                'lblConfirmPassword.Visible = False
                'btnChangePassword.Visible = True
                txtFullname.Focus()
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim dtUsers As New DataTable
            If NetOpen(dtUsers, "select * from users where user_id=" & mSearchID) = True Then
                If dtUsers.Rows.Count > 0 Then
                    txtUsername.ReadOnly = True
                    txtUser_Password.Visible = False
                    txtConfirm.Visible = False
                    lblPassword.Visible = False
                    lblConfirm.Visible = False
                    btnShowResetPassword.Visible = True
                    For Each drUser As DataRow In dtUsers.Rows
                        mUser_ID = CType(drUser.Item("user_id"), Integer)
                        txtFullname.Text = CType(drUser.Item("fullname"), String)
                        txtUsername.Text = CType(drUser.Item("username"), String)
                        chkMnu_Users.Checked = CType(drUser.Item("mnu_user"), Boolean)
                        chkMnu_Employee_Info.Checked = CType(drUser.Item("mnu_employee_info"), Boolean)
                        chkMnu_Schedules.Checked = CType(drUser.Item("mnu_schedules"), Boolean)
                        chkMnu_Cutoff_Periods.Checked = CType(drUser.Item("mnu_cutoff_periods"), Boolean)
                        chkMnu_Assign_Schedules.Checked = CType(drUser.Item("mnu_assign_schedules"), Boolean)
                        chkMnu_Generate_DTR.Checked = CType(drUser.Item("mnu_generate_dtr"), Boolean)
                        chkMnu_DTR_Adjustments.Checked = CType(drUser.Item("mnu_dtr_adjustments"), Boolean)
                        chkMnu_Print_DTR.Checked = CType(drUser.Item("mnu_print_dtr"), Boolean)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        gbResetPassword.Location = New System.Drawing.Point(7, 38)
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        If Trim(txtRPassword.Text) = "" Then
            MsgBox("Please provide a password.", MsgBoxStyle.Exclamation)
            txtRPassword.Focus()
            Exit Sub
        End If
        If Trim(txtRPassword.Text) <> Trim(txtRConfirm.Text) Then
            MsgBox("Passwords don't match.", MsgBoxStyle.Exclamation)
            txtRConfirm.Focus()
            Exit Sub
        End If
        Try
            Dim mTrans As MySqlTransaction
            Dim mCommand As New MySqlCommand
            mTrans = Cn.Connection.BeginTransaction
            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection
            mCommand.CommandText = "update users set user_password=password(@user_password) " & _
                                    "where user_id = @user_id"
            mCommand.Parameters.AddWithValue("@user_id", mUser_ID)
            mCommand.Parameters.AddWithValue("@user_password", txtRPassword.Text)
            mCommand.ExecuteNonQuery()
            mTrans.Commit()
            mTrans.Dispose()
            MsgBox("Password has been successfully updated.", MsgBoxStyle.Information)
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnBack.Enabled = True
            gbUser.Enabled = True
            gbResetPassword.Visible = False
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnShowResetPassword_Click(sender As System.Object, e As System.EventArgs) Handles btnShowResetPassword.Click
        btnNew.Enabled = False
        btnSave.Enabled = False
        btnBack.Enabled = False
        gbUser.Enabled = False
        gbResetPassword.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnBack.Enabled = True
        gbUser.Enabled = True
        gbResetPassword.Visible = False
    End Sub
End Class