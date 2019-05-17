Public Class frmAdminTasks

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call frmSecurityVerification.Close()
        Call Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmUsers
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub frmAdminTasks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnUsers.Enabled = CType(User.Menu_User, Boolean)
        btnEmployeeInfo.Enabled = CType(User.Menu_Employee_Info, Boolean)
        btnSchedules.Enabled = CType(User.Menu_Schedules, Boolean)
        btnCutoffPeriods.Enabled = CType(User.Menu_Cutoff_Periods, Boolean)
        btnAssignSchedules.Enabled = CType(User.Menu_Assign_Schedules, Boolean)
        btnGenerateDTR.Enabled = CType(User.Menu_Generate_DTR, Boolean)
        btnDTRAdjustments.Enabled = CType(User.Menu_DTR_Adjustments, Boolean)
        btnPrintDTR.Enabled = CType(User.Menu_Print_DTR, Boolean)
    End Sub

    Private Sub btnEmployeeInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeeInfo.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmEmployeeInfo
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnSchedules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedules.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmSchedules
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnCutoffPeriods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCutoffPeriods.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmCutOffPeriods
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnAssignSchedules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignSchedules.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmAssignSchedules
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnDTRAdjustments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDTRAdjustments.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmImportDTR
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnPrintDTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDTR.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmRPDTRs
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub

    Private Sub btnGenerateDTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateDTR.Click
        Call Hide()
        Dim mForm As Form
        mForm = New frmHolidaySchedules
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
    End Sub
End Class