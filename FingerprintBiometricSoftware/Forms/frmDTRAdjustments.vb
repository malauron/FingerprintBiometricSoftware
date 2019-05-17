Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmDTRAdjustments

    Dim mSchedule_ID As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        mLogUpdated = False
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mSchedule_ID = 0
        txt1st_insched.Value = vbNull
        txt1st_outsched.Value = vbNull
        txt2nd_insched.Value = vbNull
        txt2nd_outsched.Value = vbNull
        txt3rd_insched.Value = vbNull
        txt3rd_outsched.Value = vbNull
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim dtSchedules As New DataTable
            If NetOpen(dtSchedules, "select * from schedules where schedule_id =" & mSearchID) = True Then
                If dtSchedules.Rows.Count > 0 Then
                    Call Clear_Fields()
                    For Each drSchedule As DataRow In dtSchedules.Rows
                        mSchedule_ID = mSearchID
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
        mLogUpdated = True
        mNewLog1 = ""
        mNewLog2 = ""
        mNewLog3 = ""
        mNewLog4 = ""
        mNewLog5 = ""
        mNewLog6 = ""
        If Not IsDBNull(txt1st_insched.Value) Then mNewLog1 = CType(txt1st_insched.Value, String)
        If Not IsDBNull(txt1st_outsched.Value) Then mNewLog2 = CType(txt1st_outsched.Value, String)
        If Not IsDBNull(txt2nd_insched.Value) Then mNewLog3 = CType(txt2nd_insched.Value, String)
        If Not IsDBNull(txt2nd_outsched.Value) Then mNewLog4 = CType(txt2nd_outsched.Value, String)
        If Not IsDBNull(txt3rd_insched.Value) Then mNewLog5 = CType(txt3rd_insched.Value, String)
        If Not IsDBNull(txt3rd_outsched.Value) Then mNewLog6 = CType(txt3rd_outsched.Value, String)
        Call Close()

    End Sub

    Private Sub frmDTRAdjustments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Trim(mNewLog1) <> "" Then txt1st_insched.Value = CType(mNewLog1, DateTime)
        If Trim(mNewLog2) <> "" Then txt1st_outsched.Value = CType(mNewLog2, DateTime)
        If Trim(mNewLog3) <> "" Then txt2nd_insched.Value = CType(mNewLog3, DateTime)
        If Trim(mNewLog4) <> "" Then txt2nd_outsched.Value = CType(mNewLog4, DateTime)
        If Trim(mNewLog5) <> "" Then txt3rd_insched.Value = CType(mNewLog5, DateTime)
        If Trim(mNewLog6) <> "" Then txt3rd_outsched.Value = CType(mNewLog6, DateTime)
    End Sub
End Class