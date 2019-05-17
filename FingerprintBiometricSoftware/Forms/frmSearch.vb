Public Class frmSearch
    Dim myData As New DataTable

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim mQuery As String = ""
        Select Case mSearchFormName
            Case "frmUsers"
                mQuery = "select user_id id,fullname description from users where fullname like '%" & ConSwap(txtSearch.Text) & "%' order by fullname"
            Case "frmEmployeeInfo"
                mQuery = "select employee_id id,concat(lastname,', ',firstname,' ',middlename) description from employees where concat(lastname,firstname,middlename) like '%" & ConSwap(txtSearch.Text) & "%' order by lastname,firstname,middlename"
            Case "frmSchedules"
                mQuery = "select schedule_id id,description from schedules where description like '%" & ConSwap(txtSearch.Text) & "%' order by description"
            Case "frmCutOffPeriods"
                mQuery = "SELECT cutoff_period_id id,CONCAT(DATE_FORMAT(start_date,'%m/%d/%Y'),' - ',DATE_FORMAT(end_date,'%m/%d/%Y')) description FROM cutoff_periods ORDER BY cutoff_period_id DESC"
            Case "frmHolidaySchedules"
                mQuery = "SELECT holiday_id id,CONCAT(UCASE(DATE_FORMAT(work_date,'%y %b %d')),' - ',description) description FROM holidays_header ORDER BY work_date DESC"
            Case "Departments"
                mQuery = "select department_id id,description from departments where description like '%" & ConSwap(txtSearch.Text) & "%' order by description"
        End Select
        If NetOpen(myData, mQuery, Cn.Connection) = True Then
            With tdbSearch
                .SetDataBinding(myData, "", True)
            End With
        End If
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case mSearchFormName
            Case "frmUsers"
                tdbSearch.Columns("description").Caption = "User Full Names"
            Case "frmEmployeeInfo"
                tdbSearch.Columns("description").Caption = "Employee Names"
            Case "frmSchedules"
                tdbSearch.Columns("description").Caption = "Schedules"
            Case "frmCutOffPeriods"
                tdbSearch.Columns("description").Caption = "Cutoff Periods"
        End Select
    End Sub

    Private Sub tdbSearch_DoubleClick(sender As Object, e As System.EventArgs) Handles tdbSearch.DoubleClick
        If myData.Rows.Count > 0 Then
            mSearchID = CType(tdbSearch.Columns("id").Value, Integer)
            Me.Close()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If myData.Rows.Count > 0 Then
            mSearchID = CType(tdbSearch.Columns("id").Value, Integer)
            Me.Close()
        End If
    End Sub

End Class