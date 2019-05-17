Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmCutOffPeriods

    Dim mCutOff_Period_ID As Integer
    Dim mOutlets As New DataTable
    Dim mJobtitles As New DataTable
    Dim mPicChange As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mPicChange = False
        mCutOff_Period_ID = 0
        dtpDateFrom.Value = Now
        dtpDateUntil.Value = Now
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim dtSchedules As New DataTable
            If NetOpen(dtSchedules, "select * from cutoff_periods where cutoff_period_id =" & mSearchID) = True Then
                If dtSchedules.Rows.Count > 0 Then
                    Call Clear_Fields()
                    For Each drCutOffPeriods As DataRow In dtSchedules.Rows
                        mCutOff_Period_ID = mSearchID
                        dtpDateFrom.Value = CType(drCutOffPeriods.Item("start_date"), DateTime)
                        dtpDateUntil.Value = CType(drCutOffPeriods.Item("end_date"), DateTime)
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

        mTrans = Cn.Connection.BeginTransaction
        mTransLock = cnLock.Connection.BeginTransaction

        Try
            mCmdLock.Transaction = mTransLock
            mCmdLock.Connection = cnLock.Connection
            mCmdLock.CommandText = "LOCK TABLES trans_lock WRITE"
            mCmdLock.ExecuteNonQuery()

            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection

            If mCutOff_Period_ID = 0 Then
                mCommand.CommandText = "select cutoff_period_id from cutoff_periods where " & _
                                       "start_date <='" & Format(dtpDateUntil.Value, "yyyy-MM-dd") & "' and end_date >= '" & Format(dtpDateFrom.Value, "yyyy-MM-dd") & "'"
            Else
                mCommand.CommandText = "select cutoff_period_id from cutoff_periods where " & _
                                       "(start_date <= '" & Format(dtpDateUntil.Value, "yyyy-MM-dd") & "' and end_date >='" & Format(dtpDateFrom.Value, "yyyy-MM-dd") & "') and " & _
                                       "cutoff_period_id <> @cutoff_period_id"
                mCommand.Parameters.AddWithValue("@cutoff_period_id", mCutOff_Period_ID)
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
                MsgBox("Your defined dates overlap some of the existing cutoff settings.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
                dtpDateFrom.Focus()
                Exit Sub
            Else
                rdQuery.Close()
            End If
            If mCutOff_Period_ID = 0 Then
                mCommand.CommandText = "insert into cutoff_periods (start_date,end_date) values (@start_date,@end_date)"
            Else
                mCommand.CommandText = "update cutoff_periods set start_date=@start_date,end_date=@end_date where cutoff_period_id=@cutoff_period_id"
            End If
            mCommand.Parameters.AddWithValue("@start_date", Format(dtpDateFrom.Value, "yyyy-MM-dd"))
            mCommand.Parameters.AddWithValue("@end_date", Format(dtpDateUntil.Value, "yyyy-MM-dd"))
            mCommand.ExecuteNonQuery()
            If mCutOff_Period_ID = 0 Then
                mCutOff_Period_ID = CType(mCommand.LastInsertedId, Integer)
                mCommand.Parameters.AddWithValue("@cutoff_period_id", mCutOff_Period_ID)
            End If

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
        If mCutOff_Period_ID = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to define new cutoff period?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call Clear_Fields()
    End Sub

    Private Sub frmCutOffPeriods_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpDateFrom.Value = Now
        dtpDateUntil.Value = Now
    End Sub
End Class