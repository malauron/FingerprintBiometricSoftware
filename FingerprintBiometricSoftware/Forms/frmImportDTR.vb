Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmImportDTR

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub frmImportDTR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim mIDs As String
        'Dim mDateTime As String
        'Dim mInString As Integer
        'For Each line As String In System.IO.File.ReadAllLines("e:\1_attlog.dat")
        '    If Microsoft.VisualBasic.Left(line.ToString, 1) <> "S" And Microsoft.VisualBasic.Left(line.ToString, 1) <> "C" Then
        '        mInString = InStr(line.ToString, CChar(vbTab))
        '        mIDs = Microsoft.VisualBasic.Left(line.ToString, mInString - 1)
        '        mDateTime = Microsoft.VisualBasic.Mid(line.ToString, mInString + 1, 19)
        '        'MsgBox("Employee ID: " & mIDs & vbCrLf & "Date & Time : " & mDateTime)
        '        'DataGridView1.Rows.Add(line.Split(CChar(vbTab)))
        '    End If
        'Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        btnSave.Enabled = False

        Dim mTrans As MySqlTransaction
        Dim mCommand As New MySqlCommand
        Dim dtEmployees As New DataTable
        Dim mIDs As String
        Dim mDateTime As String
        Dim mInString As Integer
        Dim mLogStat As Integer

        With My.Computer.FileSystem
            If Trim(lblPath.Text) <> "" Then
                If Not .FileExists(lblPath.Text) Then
                    MsgBox("Invalid file format.", MsgBoxStyle.Exclamation)
                    btnSave.Enabled = True
                    Exit Sub
                End If
            Else
                MsgBox("Invalid file format.", MsgBoxStyle.Exclamation)
                btnSave.Enabled = True
                Exit Sub
            End If
        End With

        mTrans = Cn.Connection.BeginTransaction

        Try
            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection
            For Each line As String In System.IO.File.ReadAllLines(lblPath.Text)
                'MsgBox(line.ToArray.Count)
                If Microsoft.VisualBasic.Left(line.ToString, 1) <> "S" And Microsoft.VisualBasic.Left(line.ToString, 1) <> "C" Then
                    mInString = InStr(line.ToString, CChar(vbTab))
                    mIDs = Microsoft.VisualBasic.Left(line.ToString, mInString - 1)
                    mDateTime = Microsoft.VisualBasic.Mid(line.ToString, mInString + 1, 19)
                    If CType(Format(dtpDateFrom.Value, "MM/dd/yyyy"), Date) <= CType(mDateTime, Date) Then
                        mLogStat = CType(Microsoft.VisualBasic.Mid(line.ToString, mInString + 23, 1), Integer)
                        If mLogStat <= 1 Or mLogStat = 3 Then
                            mLogStat = 1
                        Else
                            mLogStat = 0
                        End If
                        mCommand.CommandText = "insert ignore into employee_logs(employee_id,datetime_log,log_status) values (" & "" & CType(Trim(mIDs), Integer) & "," & _
                                                       "'" & Format(CType(mDateTime, Date), "yyyy-MM-dd HH:mm:ss") & "'," & mLogStat & ")"
                        mCommand.ExecuteNonQuery()
                    End If
                End If
            Next
            mTrans.Commit()
            Call Create_DTR()
            If NetOpen(dtEmployees, "select a.employee_id,b.department_id from " & _
                                "(select employee_id from employee_dtrs where work_date BETWEEN '" & Format(dtpDateFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(Now.Date, "yyyy-MM-dd") & "' group by employee_id) a " & _
                                "left outer join employees b on a.employee_id=b.employee_id") Then
                If dtEmployees.Rows.Count > 0 Then
                    For Each mEmpIDs As DataRow In dtEmployees.Rows
                        'MsgBox(dtpDateFrom.Value & "  -   " & Now.Date)                        
                        ComputeDTR(CType(mEmpIDs.Item("employee_id"), Integer), dtpDateFrom.Value, Now.Date, CType(mEmpIDs.Item("department_id"), Integer))
                    Next
                End If
            End If
            MsgBox("Upload complete!", MsgBoxStyle.Information)
        Catch ex As MySqlException
            If Not (mTrans Is Nothing) Then
                mTrans.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            If Not (mTrans Is Nothing) Then
                mTrans.Rollback()
            End If
            MsgBox("Invalid file format.", MsgBoxStyle.Exclamation)
            'MsgBox(ex.Message)
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

    Private Sub Create_DTR()

        Dim mTrans As MySqlTransaction
        Dim mCommand As New MySqlCommand
        Dim mDateFrom As Date
        Dim mCurrDate As Date
        Dim mEmployee_IDs As New DataTable
        Dim employee_logs As New DataTable
        Dim mHolidays As New DataTable
        Dim mFirstIN As Boolean = True
        Dim mColNum As Integer = 1

        mDateFrom = CType(Format(dtpDateFrom.Value, "MM/dd/yyyy"), Date)

        mTrans = Cn.Connection.BeginTransaction
        Try
            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection

            'delete existing dtrs for the selected period
            mCommand.CommandText = "delete from employee_dtrs where work_date >= '" & Format(mDateFrom, "yyyy-MM-dd") & "'"
            mCommand.ExecuteNonQuery()
            mCommand.CommandText = "delete from schedules_assignment where work_date >= '" & Format(mDateFrom, "yyyy-MM-dd") & "' and schedule_id=0"
            mCommand.ExecuteNonQuery()
            mCommand.CommandText = "update schedules_assignment set department_id=(select department_id from employees where employee_id=schedules_assignment.employee_id) " & _
                                                "where work_date >= '" & Format(mDateFrom, "yyyy-MM-dd") & "'"
            mCommand.ExecuteNonQuery()
            'create new dtrs       

            NetOpen(mEmployee_IDs, "select a.*,b.schedule_id,b.department_id from (select employee_id from employee_logs where employee_id in (select employee_id from employees) and " & _
                                   "date(datetime_log) >='" & Format(mDateFrom, "yyyy-MM-dd") & "'group by employee_id) a " & _
                                   "left outer join employees b on a.employee_id=b.employee_id ", Cn.Connection)

            For Each mEmpID As DataRow In mEmployee_IDs.Rows
                NetOpen(employee_logs, "select * from employee_logs where employee_id = " & CType(mEmpID.Item("employee_id"), String) & " and " & _
                                    "date(datetime_log) >= '" & Format(mDateFrom, "yyyy-MM-dd") & "' order by datetime_log", Cn.Connection)

                NetOpen(mHolidays, "select b.* from holidays_line a " & _
                                    "left outer join holidays_header b on a.holiday_id=b.holiday_id " & _
                                    "where b.work_date >= '" & Format(mDateFrom, "yyyy-MM-dd") & "' and a.department_id=" & CType(mEmpID.Item("department_id"), Integer))
                For Each mHldys As DataRow In mHolidays.Rows
                    mCommand.CommandText = "insert ignore into schedules_assignment (employee_id,schedule_id,work_date,department_id) values (" & _
                                        "" & CType(mEmpID.Item("employee_id"), String) & "," & CType(mEmpID.Item("schedule_id"), String) & ",'" & Format(CType(mHldys.Item("work_date"), Date), "yyyy-MM-dd") & "'," & CType(mEmpID.Item("department_id"), Integer) & ")"
                    mCommand.ExecuteNonQuery()
                Next

                mFirstIN = True
                For Each mLog As DataRow In employee_logs.Rows
                    If Not mFirstIN Then
                        If mCurrDate <> CType(Format(mLog.Item("datetime_log"), "MM/dd/yyyy"), Date) Then
                            If CType(mLog.Item("log_status"), Integer) = 1 Then
                                mColNum = 1
                                mCurrDate = CType(Format(mLog.Item("datetime_log"), "MM/dd/yyyy"), Date)
                                mCommand.CommandText = "insert ignore into schedules_assignment (employee_id,schedule_id,work_date,department_id) values (" & _
                                            "" & CType(mEmpID.Item("employee_id"), String) & "," & CType(mEmpID.Item("schedule_id"), String) & ",'" & Format(mCurrDate, "yyyy-MM-dd") & "'," & CType(mEmpID.Item("department_id"), Integer) & ")"
                                mCommand.ExecuteNonQuery()
                                mCommand.CommandText = "insert into employee_dtrs (employee_id,work_date,log1) values " & _
                                            "(" & CType(mEmpID.Item("employee_id"), String) & ",'" & Format(mCurrDate, "yyyy-MM-dd") & "'," & _
                                            "'" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "')"
                                mCommand.ExecuteNonQuery()
                                mColNum = mColNum + 1
                            Else
                                If mColNum = 2 Or mColNum = 4 Or mColNum = 6 Then
                                    mCommand.CommandText = "update employee_dtrs set log" & mColNum & "='" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "' " & _
                                                    "where employee_id=" & CType(mEmpID.Item("employee_id"), String) & " and work_date='" & Format(mCurrDate, "yyyy-MM-dd") & "'"
                                    mCommand.ExecuteNonQuery()
                                    mColNum = mColNum + 1
                                End If
                            End If
                        Else
                            If CType(mLog.Item("log_status"), Integer) = 1 Then
                                If mColNum = 3 Or mColNum = 5 Then
                                    mCommand.CommandText = "update employee_dtrs set log" & mColNum & "='" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "' " & _
                                                "where employee_id=" & CType(mEmpID.Item("employee_id"), String) & " and work_date='" & Format(mCurrDate, "yyyy-MM-dd") & "'"
                                    mCommand.ExecuteNonQuery()
                                    mColNum = mColNum + 1
                                Else
                                    If mColNum + 1 < 6 Then
                                        mCommand.CommandText = "update employee_dtrs set log" & mColNum + 1 & "='" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "' " & _
                                                "where employee_id=" & CType(mEmpID.Item("employee_id"), String) & " and work_date='" & Format(mCurrDate, "yyyy-MM-dd") & "'"
                                        mCommand.ExecuteNonQuery()
                                        mColNum = mColNum + 2
                                    End If
                                End If
                            Else
                                If mColNum = 2 Or mColNum = 4 Or mColNum = 6 Then
                                    mCommand.CommandText = "update employee_dtrs set log" & mColNum & "='" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "' " & _
                                                "where employee_id=" & CType(mEmpID.Item("employee_id"), String) & " and work_date='" & Format(mCurrDate, "yyyy-MM-dd") & "'"
                                    mCommand.ExecuteNonQuery()
                                    mColNum = mColNum + 1
                                Else
                                    If mColNum < 6 Then
                                        mCommand.CommandText = "update employee_dtrs set log" & mColNum + 1 & "='" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "' " & _
                                                "where employee_id=" & CType(mEmpID.Item("employee_id"), String) & " and work_date='" & Format(mCurrDate, "yyyy-MM-dd") & "'"
                                        mCommand.ExecuteNonQuery()
                                        mColNum = mColNum + 2
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If mFirstIN Then
                        If CType(mLog.Item("log_status"), Integer) = 1 Then
                            mFirstIN = False
                            mColNum = 2
                            mCurrDate = CType(Format(mLog.Item("datetime_log"), "MM/dd/yyyy"), Date)
                            mCommand.CommandText = "insert ignore into schedules_assignment (employee_id,schedule_id,work_date,department_id) values (" & _
                                            "" & CType(mEmpID.Item("employee_id"), String) & "," & CType(mEmpID.Item("schedule_id"), String) & ",'" & Format(mCurrDate, "yyyy-MM-dd") & "'," & CType(mEmpID.Item("department_id"), Integer) & ")"
                            mCommand.ExecuteNonQuery()
                            mCommand.CommandText = "insert into employee_dtrs (employee_id,work_date,log1) values " & _
                                        "(" & CType(mEmpID.Item("employee_id"), String) & ",'" & Format(mCurrDate, "yyyy-MM-dd") & "','" & Format(CType(mLog.Item("datetime_log"), Date), "yyyy-MM-dd HH:mm:ss") & "')"
                            mCommand.ExecuteNonQuery()
                        End If
                    End If
                Next
            Next
            mTrans.Commit()
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
            MsgBox(ex.Data)
        Finally
            Try
                mCommand.Dispose()
                mTrans.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                btnNew.Enabled = True
            End Try
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim dtEmployees As New DataTable
        Call Create_DTR()
        If NetOpen(dtEmployees, "select a.employee_id,b.department_id from " & _
                            "(select x1.* from (select employee_id from employee_dtrs where work_date BETWEEN '" & Format(dtpDateFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(Now.Date, "yyyy-MM-dd") & "' " & _
                            "union all " & _
                            "select employee_id from employee_dtr_adjustments where work_date BETWEEN '" & Format(dtpDateFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(Now.Date, "yyyy-MM-dd") & "') x1 group by x1.employee_id) a " & _
                            "left outer join employees b on a.employee_id=b.employee_id") Then
            If dtEmployees.Rows.Count > 0 Then
                For Each mEmpIDs As DataRow In dtEmployees.Rows
                    'MsgBox(dtpDateFrom.Value & "  -   " & Now.Date)
                    ComputeDTR(CType(mEmpIDs.Item("employee_id"), Integer), dtpDateFrom.Value, Now.Date, CType(mEmpIDs.Item("department_id"), Integer))
                Next
            End If
        End If
        MsgBox("Process complete!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If ofdLogs.ShowDialog() = DialogResult.OK Then
            lblPath.Text = ofdLogs.FileName
        End If
    End Sub

End Class