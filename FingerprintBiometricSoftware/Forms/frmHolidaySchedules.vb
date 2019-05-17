Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmHolidaySchedules

    Dim mHoliday_ID As Integer
    Dim myData As New DataTable

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mHoliday_ID = 0
        dtpSchedDate.Value = Now
        txtDescription.Text = ""
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim dtSchedules As New DataTable
            If NetOpen(dtSchedules, "select * from holidays_header where holiday_id =" & mSearchID) = True Then
                If dtSchedules.Rows.Count > 0 Then
                    Call Clear_Fields()
                    For Each drHolidays As DataRow In dtSchedules.Rows
                        mHoliday_ID = mSearchID
                        dtpSchedDate.Value = CType(drHolidays.Item("work_date"), DateTime)
                        txtDescription.Text = CType(drHolidays.Item("description"), String)
                        If CType(drHolidays.Item("holiday_type"), String) = "REG" Then
                            rdbRegular.Checked = True
                        Else
                            rdbSpecial.Checked = True
                        End If
                    Next
                    If NetOpen(myData, "SELECT x1.department_id,x2.isChecked,x1.description FROM departments x1 " & _
                                        "LEFT OUTER JOIN (SELECT 'True' isChecked,b.`department_id` FROM holidays_header a " & _
                                        "                 LEFT OUTER JOIN holidays_line b ON a.`holiday_id`=b.`holiday_id` " & _
                                        "                 WHERE a.holiday_id = " & mSearchID & ") x2 ON x1.department_id=x2.department_id " & _
                                        "ORDER BY x1.description", Cn.Connection) = True Then
                        dgvDepartments.DataSource = myData
                    End If
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

        Dim mHoliday_Type As String = "REG"

        mTrans = Cn.Connection.BeginTransaction
        mTransLock = cnLock.Connection.BeginTransaction

        Try
            mCmdLock.Transaction = mTransLock
            mCmdLock.Connection = cnLock.Connection
            mCmdLock.CommandText = "LOCK TABLES trans_lock WRITE"
            mCmdLock.ExecuteNonQuery()

            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection

            If mHoliday_ID = 0 Then
                mCommand.CommandText = "select work_date from holidays_header where " & _
                                       "work_date ='" & Format(dtpSchedDate.Value, "yyyy-MM-dd") & "'"
            Else
                mCommand.CommandText = "select work_date from holidays_header where " & _
                                       "work_date = '" & Format(dtpSchedDate.Value, "yyyy-MM-dd") & "' and " & _
                                       "holiday_id <> @Holiday_ID"
                mCommand.Parameters.AddWithValue("@Holiday_ID", mHoliday_ID)
            End If
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
                MsgBox("Your defined date overlaps some existing holiday schedules.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
                dtpSchedDate.Focus()
                Exit Sub
            Else
                rdQuery.Close()
            End If
            If mHoliday_ID = 0 Then
                mCommand.CommandText = "insert into holidays_header (description,work_date,holiday_type) values (@description,@work_date,@holiday_type)"
            Else
                mCommand.CommandText = "update holidays_header set description=@description,work_date=@work_date,holiday_type=@holiday_type where Holiday_ID=@Holiday_ID"
            End If
            If rdbRegular.Checked Then
                mHoliday_Type = "REG"
            Else
                mHoliday_Type = "SPC"
            End If

            mCommand.Parameters.AddWithValue("@description", txtDescription.Text)
            mCommand.Parameters.AddWithValue("@work_date", Format(dtpSchedDate.Value, "yyyy-MM-dd"))
            mCommand.Parameters.AddWithValue("@holiday_type", mHoliday_Type)
            mCommand.ExecuteNonQuery()

            If mHoliday_ID = 0 Then
                mHoliday_ID = CType(mCommand.LastInsertedId, Integer)
                mCommand.Parameters.AddWithValue("@Holiday_ID", mHoliday_ID)
            End If

            mCommand.CommandText = "delete from holidays_line where holiday_id=@Holiday_ID"
            mCommand.ExecuteNonQuery()

            With dgvDepartments
                If .RowCount > 0 Then
                    For i = 0 To .RowCount - 1
                        If Not IsDBNull(.Item("isChecked", i).Value) Then
                            'MsgBox(.Item("isChecked", i).Value)
                            mCommand.CommandText = "insert into holidays_line values (@Holiday_ID," & CType(.Item("department_id", i).Value, String) & ")"
                            mCommand.ExecuteNonQuery()
                        End If
                    Next
                End If
            End With

            mTrans.Commit()

            mCmdLock.CommandText = "UNLOCK TABLES"
            mCmdLock.ExecuteNonQuery()
            mCmdLock.Dispose()
            mTransLock.Rollback()
            mCmdLock.Dispose()
            mTransLock.Dispose()

            MsgBox("Information has been succesfully saved!", MsgBoxStyle.Information)
            'txtDescription.Focus()
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
        If mHoliday_ID = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to create new holiday schedule?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call Clear_Fields()
    End Sub

    Private Sub frmCutOffPeriods_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpSchedDate.Value = Now
        txtDescription.Text = ""
        If NetOpen(myData, "select department_id,null isChecked,description from departments order by description", Cn.Connection) = True Then
            dgvDepartments.DataSource = myData
        End If
    End Sub

   
End Class