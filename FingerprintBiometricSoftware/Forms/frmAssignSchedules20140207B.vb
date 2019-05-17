Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAssignSchedules20140207

    Dim mCutOff_Period_ID As Integer
    Dim mAssignSchedules As New DataTable
    Dim mSchedules As New DataTable

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mCutOff_Period_ID = 0
        txtCutoffPeriod.Text = ""
        txtCutoffPeriod.Tag = 0
        txtEmployeeName.Text = ""
        txtEmployeeName.Tag = 0
        With tdbAssignSchedules
            .DataSource = Nothing
            If NetOpen(mAssignSchedules, "select null work_date, 0 schedule_id, 'No Schedule' schedule_description limit 0", Cn.Connection) = True Then
                .SetDataBinding(mAssignSchedules, "", True)
            End If
        End With
        With cboSchedules
            .DataSource = Nothing
            If NetOpen(mSchedules, "select 0 schedule_id,'No Schedule' description " & _
                                    "Union All " & _
                                    "select schedule_id,description from schedules " & _
                                    "order by schedule_id", Cn.Connection) = True Then
                .HoldFields()
                .DisplayMember = "description"
                .ValueMember = "schedule_id"
                .DataSource = mSchedules
            End If
        End With
    End Sub

    Private Sub btnBrowseEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseEmployee.Click
        mSearchID = CType(txtEmployeeName.Tag, Integer)
        Call Get_ID("frmEmployeeInfo")
        If mSearchID > 0 Then
            Dim dtEmployees As New DataTable
            If NetOpen(dtEmployees, "SELECT CONCAT(lastname,', ',firstname,' ',middlename) description FROM employees where employee_id =" & mSearchID) = True Then
                If dtEmployees.Rows.Count > 0 Then
                    For Each drEmployee As DataRow In dtEmployees.Rows
                        txtEmployeeName.Tag = mSearchID
                        txtEmployeeName.Text = CType(drEmployee.Item("description"), String)
                        If CType(txtCutoffPeriod.Tag, Integer) > 0 And CType(txtEmployeeName.Tag, Integer) > 0 Then
                            Call Load_Schedules()
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        btnSave.Enabled = False

        Dim mTrans As MySqlTransaction
        Dim mCommand As New MySqlCommand
        Dim mDateFrom As Date
        Dim mDateUntil As Date
        Dim mEditLog1 As String = ""
        Dim mEditLog2 As String = ""
        Dim mEditLog3 As String = ""
        Dim mEditLog4 As String = ""
        Dim mEditLog5 As String = ""
        Dim mEditLog6 As String = ""

        mTrans = Cn.Connection.BeginTransaction

        Try
            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection
            mDateFrom = CType(Mid(txtCutoffPeriod.Text, 1, 10), Date)
            mDateUntil = CType(Mid(txtCutoffPeriod.Text, 14, 10), Date)
            mCommand.CommandText = "delete from schedules_assignment where employee_id=@employee_id and (work_date between @datefrom and @dateuntil)"
            mCommand.Parameters.AddWithValue("@employee_id", txtEmployeeName.Tag)
            mCommand.Parameters.AddWithValue("@datefrom", Format(mDateFrom, "yyyy-MM-dd"))
            mCommand.Parameters.AddWithValue("@dateuntil", Format(mDateUntil, "yyyy-MM-dd"))
            mCommand.ExecuteNonQuery()
            mCommand.CommandText = "delete from employee_dtr_adjustments where employee_id=@employee_id and (work_date between @datefrom and @dateuntil)"
            mCommand.ExecuteNonQuery()
            Dim mRow As Integer = 0
            With tdbAssignSchedules
                If .RowCount > 0 Then
                    Do While mRow <= .RowCount - 1


                        mCommand.CommandText = "insert into schedules_assignment(employee_id,schedule_id,work_date) values (" & _
                                    "" & CType(txtEmployeeName.Tag, Integer) & "," & _
                                    "" & CType(.Item(mRow, "schedule_id"), Integer) & "," & _
                                    "'" & Format(CType(.Item(mRow, "work_date"), Date), "yyyy-MM-dd") & "')"
                        mCommand.ExecuteNonQuery()

                        If CType(.Item(mRow, "isedited"), String) = "Y" Then
                            mEditLog1 = "Null"
                            mEditLog2 = "Null"
                            mEditLog3 = "Null"
                            mEditLog4 = "Null"
                            mEditLog5 = "Null"
                            mEditLog6 = "Null"

                            If Not IsDBNull(.Item(mRow, "edit_log1")) Then mEditLog1 = "'" & Format(CType(.Item(mRow, "edit_log1"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            If Not IsDBNull(.Item(mRow, "edit_log2")) Then mEditLog2 = "'" & Format(CType(.Item(mRow, "edit_log2"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            If Not IsDBNull(.Item(mRow, "edit_log3")) Then mEditLog3 = "'" & Format(CType(.Item(mRow, "edit_log3"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            If Not IsDBNull(.Item(mRow, "edit_log4")) Then mEditLog4 = "'" & Format(CType(.Item(mRow, "edit_log4"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            If Not IsDBNull(.Item(mRow, "edit_log5")) Then mEditLog5 = "'" & Format(CType(.Item(mRow, "edit_log5"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            If Not IsDBNull(.Item(mRow, "edit_log6")) Then mEditLog6 = "'" & Format(CType(.Item(mRow, "edit_log6"), DateTime), "yyyy-MM-dd HH:mm:00") & "'"
                            mCommand.CommandText = "insert into employee_dtr_adjustments(employee_id,work_date,log1,log2,log3,log4,log5,log6) values (" & _
                                        "" & CType(txtEmployeeName.Tag, Integer) & "," & _
                                        "'" & Format(CType(.Item(mRow, "work_date"), Date), "yyyy-MM-dd") & "'," & _
                                        mEditLog1 & "," & mEditLog2 & "," & mEditLog3 & "," & mEditLog4 & "," & mEditLog5 & "," & mEditLog6 & ")"
                            mCommand.ExecuteNonQuery()
                        End If

                        mRow += 1
                    Loop
                End If
            End With
            mTrans.Commit()
            MsgBox("Information has been succesfully saved!", MsgBoxStyle.Information)
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
        If mCutOff_Period_ID = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to define new cutoff period?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call Clear_Fields()
    End Sub

    Private Sub frmCutOffPeriods_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Clear_Fields()
        tdbAssignSchedules.Columns("schedule_description").Editor = cboSchedules
        'dtpDateFrom.Value = Now
        'dtpDateUntil.Value = Now
    End Sub

    Private Sub btnBrowseCutoffPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseCutoffPeriod.Click
        mSearchID = CType(txtCutoffPeriod.Tag, Integer)
        Call Get_ID("frmCutOffPeriods")
        If mSearchID > 0 Then
            Dim dtCutoffPeriods As New DataTable
            If NetOpen(dtCutoffPeriods, "SELECT CONCAT(DATE_FORMAT(start_date,'%m/%d/%Y'),' - ',DATE_FORMAT(end_date,'%m/%d/%Y')) description FROM cutoff_periods where cutoff_period_id =" & mSearchID) = True Then
                If dtCutoffPeriods.Rows.Count > 0 Then
                    For Each drCutoffPeriod As DataRow In dtCutoffPeriods.Rows
                        txtCutoffPeriod.Tag = mSearchID
                        txtCutoffPeriod.Text = CType(drCutoffPeriod.Item("description"), String)
                        If CType(txtCutoffPeriod.Tag, Integer) > 0 And CType(txtEmployeeName.Tag, Integer) > 0 Then
                            Call Load_Schedules()
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Load_Schedules()
        Dim mAssignSchedules As New DataTable
        Dim mDateFrom As Date
        Dim mDateUntil As Date
        Dim mString As String = ""
        mDateFrom = CType(Mid(txtCutoffPeriod.Text, 1, 10), Date)
        mDateUntil = CType(Mid(txtCutoffPeriod.Text, 14, 10), Date)
        mString = "(select " & CType(txtEmployeeName.Tag, String) & " employee_id,'" & Format(mDateFrom, "yyyy-MM-dd") & "' work_date "
        Do While mDateFrom < mDateUntil
            mDateFrom = DateAdd(DateInterval.Day, 1, mDateFrom)
            mString = mString & " union all select " & CType(txtEmployeeName.Tag, String) & " employee_id,'" & Format(mDateFrom, "yyyy-MM-dd") & "' work_date"
        Loop
        mString = mString & ")"
        If NetOpen(mAssignSchedules, " select a.*,if(isnull(b.schedule_id),0,b.schedule_id) schedule_id, " & _
                    "if(isnull(c.description),'No Schedule',c.description) schedule_description, " & _
                    "TIME_FORMAT(IF(ISNULL(e.employee_id),d.log1,e.log1),'%H:%i') log1,TIME_FORMAT(IF(ISNULL(e.employee_id),d.log2,e.log2),'%H:%i') `log2`, " & _
                    "TIME_FORMAT(IF(ISNULL(e.employee_id),d.log3,e.log3),'%H:%i') log3,TIME_FORMAT(IF(ISNULL(e.employee_id),d.log4,e.log4),'%H:%i') log4, " & _
                    "TIME_FORMAT(IF(ISNULL(e.employee_id),d.log5,e.log5),'%H:%i') log5,TIME_FORMAT(IF(ISNULL(e.employee_id),d.log6,e.log6),'%H:%i') log6, " & _
                    "if(isnull(e.employee_id),'N','Y') isedited, " & _
                    "d.log1 orig_log1,d.log2 orig_log2,d.log3 orig_log3,d.log4 orig_log4,d.log5 orig_log5,d.log6 orig_log6, " & _
                    "e.log1 edit_log1,e.log2 edit_log2,e.log3 edit_log3,e.log4 edit_log4,e.log5 edit_log5,e.log6 edit_log6 " & _
                    "from " & mString & " a " & _
                    "left outer join (select * from schedules_assignment where work_date between '" & Format(CType(Mid(txtCutoffPeriod.Text, 1, 10), Date), "yyyy-MM-dd") & "' and '" & Format(CType(Mid(txtCutoffPeriod.Text, 14, 10), Date), "yyyy-MM-dd") & "') b on a.employee_id=b.employee_id and a.work_date=b.work_date " & _
                    "left outer join schedules c on b.schedule_id=c.schedule_id " & _
                    "left outer join (select * from employee_dtrs where work_date between '" & Format(CType(Mid(txtCutoffPeriod.Text, 1, 10), Date), "yyyy-MM-dd") & "' and '" & Format(CType(Mid(txtCutoffPeriod.Text, 14, 10), Date), "yyyy-MM-dd") & "') d on a.employee_id=d.employee_id and a.work_date=d.work_date " & _
                    "LEFT OUTER JOIN (select * from employee_dtr_adjustments where work_date between '" & Format(CType(Mid(txtCutoffPeriod.Text, 1, 10), Date), "yyyy-MM-dd") & "' and '" & Format(CType(Mid(txtCutoffPeriod.Text, 14, 10), Date), "yyyy-MM-dd") & "') e ON a.employee_id=e.employee_id AND a.work_date=e.work_date", Cn.Connection) = True Then
            tdbAssignSchedules.SetDataBinding(mAssignSchedules, "", True)
        End If
    End Sub

    Private Sub cboSchedules_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSchedules.KeyPress
        SearchC1Combo(cboSchedules, e)
    End Sub

    Private Sub tdbAssignSchedules_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbAssignSchedules.AfterColUpdate
        With tdbAssignSchedules
            If e.Column.DataColumn.DataField = "schedule_description" Then
                .Columns("schedule_id").Value = cboSchedules.SelectedValue
                .Columns("schedule_description").Value = cboSchedules.Columns("description").Value
            End If
        End With
    End Sub

    Private Sub tdbAssignSchedules_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles tdbAssignSchedules.BeforeColEdit
        With tdbAssignSchedules
            .Update()
            If e.Column.DataColumn.DataField = "schedule_description" Then
                cboSchedules.SelectedValue = .Columns("schedule_id").Value
            End If
        End With
    End Sub

    Private Sub tdbAssignSchedules_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbAssignSchedules.DoubleClick
        If tdbAssignSchedules.RowCount > 0 Then
            With tdbAssignSchedules
                If CType(.Columns(.Col).DataField, String) = "log1" Or CType(.Columns(.Col).DataField, String) = "log2" Or CType(.Columns(.Col).DataField, String) = "log3" Or _
                    CType(.Columns(.Col).DataField, String) = "log4" Or CType(.Columns(.Col).DataField, String) = "log5" Or CType(.Columns(.Col).DataField, String) = "log6" Then
                    mNewLog1 = ""
                    mNewLog2 = ""
                    mNewLog3 = ""
                    mNewLog4 = ""
                    mNewLog5 = ""
                    mNewLog6 = ""
                    If CType(.Columns("isedited").Value, String) = "Y" Then
                        If Not IsDBNull(.Columns("edit_log1").Value) Then mNewLog1 = CType(.Columns("edit_log1").Value, String)
                        If Not IsDBNull(.Columns("edit_log2").Value) Then mNewLog2 = CType(.Columns("edit_log2").Value, String)
                        If Not IsDBNull(.Columns("edit_log3").Value) Then mNewLog3 = CType(.Columns("edit_log3").Value, String)
                        If Not IsDBNull(.Columns("edit_log4").Value) Then mNewLog4 = CType(.Columns("edit_log4").Value, String)
                        If Not IsDBNull(.Columns("edit_log5").Value) Then mNewLog5 = CType(.Columns("edit_log5").Value, String)
                        If Not IsDBNull(.Columns("edit_log6").Value) Then mNewLog6 = CType(.Columns("edit_log6").Value, String)
                    Else
                        If Not IsDBNull(.Columns("orig_log1").Value) Then mNewLog1 = CType(.Columns("orig_log1").Value, String)
                        If Not IsDBNull(.Columns("orig_log2").Value) Then mNewLog2 = CType(.Columns("orig_log2").Value, String)
                        If Not IsDBNull(.Columns("orig_log3").Value) Then mNewLog3 = CType(.Columns("orig_log3").Value, String)
                        If Not IsDBNull(.Columns("orig_log4").Value) Then mNewLog4 = CType(.Columns("orig_log4").Value, String)
                        If Not IsDBNull(.Columns("orig_log5").Value) Then mNewLog5 = CType(.Columns("orig_log5").Value, String)
                        If Not IsDBNull(.Columns("orig_log6").Value) Then mNewLog6 = CType(.Columns("orig_log6").Value, String)
                    End If
                    Call Hide()
                    Dim mForm As Form
                    mForm = New frmDTRAdjustments
                    mForm.ShowDialog()
                    mForm.Dispose()
                    Call Show()
                    If mLogUpdated = True Then
                        .Columns("log1").Value = Nothing
                        .Columns("log2").Value = Nothing
                        .Columns("log3").Value = Nothing
                        .Columns("log4").Value = Nothing
                        .Columns("log5").Value = Nothing
                        .Columns("log6").Value = Nothing
                        .Columns("edit_log1").Value = Nothing
                        .Columns("edit_log2").Value = Nothing
                        .Columns("edit_log3").Value = Nothing
                        .Columns("edit_log4").Value = Nothing
                        .Columns("edit_log5").Value = Nothing
                        .Columns("edit_log6").Value = Nothing
                        .Columns("isedited").Value = "Y"
                        If Trim(mNewLog1) <> "" Then
                            .Columns("log1").Value = Format(CType(mNewLog1, DateTime), "HH:mm")
                            .Columns("edit_log1").Value = CType(mNewLog1, DateTime)
                        End If
                        If Trim(mNewLog2) <> "" Then
                            .Columns("log2").Value = Format(CType(mNewLog2, DateTime), "HH:mm")
                            .Columns("edit_log2").Value = CType(mNewLog2, DateTime)
                        End If
                        If Trim(mNewLog3) <> "" Then
                            .Columns("log3").Value = Format(CType(mNewLog3, DateTime), "HH:mm")
                            .Columns("edit_log3").Value = CType(mNewLog3, DateTime)
                        End If
                        If Trim(mNewLog4) <> "" Then
                            .Columns("log4").Value = Format(CType(mNewLog4, DateTime), "HH:mm")
                            .Columns("edit_log4").Value = CType(mNewLog4, DateTime)
                        End If
                        If Trim(mNewLog5) <> "" Then
                            .Columns("log5").Value = Format(CType(mNewLog5, DateTime), "HH:mm")
                            .Columns("edit_log5").Value = CType(mNewLog5, DateTime)
                        End If
                        If Trim(mNewLog6) <> "" Then
                            .Columns("log6").Value = Format(CType(mNewLog6, DateTime), "HH:mm")
                            .Columns("edit_log6").Value = CType(mNewLog6, DateTime)
                        End If
                    End If
                End If
            End With
        End If
    End Sub
End Class