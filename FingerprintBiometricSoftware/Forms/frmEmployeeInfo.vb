Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmEmployeeInfo

    Dim mEmployee_ID As Integer
    Dim mOutlets As New DataTable
    Dim mJobtitles As New DataTable
    Dim mPicChange As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call Close()
    End Sub

    Private Sub Clear_Fields()
        mPicChange = False
        mEmployee_ID = 0
        txtCode.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtSchedule.Text = ""
        txtDepartment.Text = ""
        txtSchedule.Tag = 0
        txtDepartment.Tag = 0
        chkLLF.Checked = False
        chkLRF.Checked = False
        chkLMF.Checked = False
        chkLIF.Checked = False
        chkLTF.Checked = False
        chkRLF.Checked = False
        chkRRF.Checked = False
        chkRMF.Checked = False
        chkRIF.Checked = False
        chkRTF.Checked = False
        If Not (picEmployee.Image Is Nothing) Then
            picEmployee.Image.Dispose()
        End If
        picEmployee.Image = Nothing
        mEmployeeFP.ClearAllTemplates()
        mEmployeeFP.Changed = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Call Get_ID(Me.Name)
        If mSearchID > 0 Then
            Dim mDigitalInfo As MySqlDataReader
            Dim mCmd As New MySqlCommand
            Dim dtEmployees As New DataTable
            Dim rawData() As Byte
            Dim FileSize As UInt32
            Dim fs As New MemoryStream()
            If NetOpen(dtEmployees, "select a.*,b.description,c.description department_name from employees a " & _
                        "left outer join schedules b on a.schedule_id=b.schedule_id " & _
                        "left outer join departments c on a.department_id=c.department_id " & _
                        "where a.employee_id=" & mSearchID) = True Then
                If dtEmployees.Rows.Count > 0 Then
                    Dim template As DPFP.Template
                    Call Clear_Fields()
                    For Each drEmployee As DataRow In dtEmployees.Rows
                        mEmployee_ID = mSearchID
                        txtCode.Text = CType(drEmployee.Item("employee_id"), String)
                        txtLastname.Text = CType(drEmployee.Item("lastname"), String)
                        txtFirstname.Text = CType(drEmployee.Item("firstname"), String)
                        txtMiddlename.Text = CType(drEmployee.Item("middlename"), String)
                        txtSchedule.Text = CType(IIf(IsDBNull(drEmployee.Item("description")), "", drEmployee.Item("description")), String)
                        txtSchedule.Tag = CType(drEmployee.Item("schedule_id"), String)
                        txtDepartment.Text = CType(IIf(IsDBNull(drEmployee.Item("department_name")), "", drEmployee.Item("department_name")), String)
                        txtDepartment.Tag = CType(drEmployee.Item("department_id"), String)
                    Next
                    mCmd.Connection = Cn.Connection
                    mCmd.CommandText = "select 0 finger_position,file_size,file,'emppic' file_type from employee_pictures where employee_id = " & mSearchID & " " & _
                                       "union all " & _
                                       "select finger_position,file_size,file,'empsig' file_type from employee_fingerprints where employee_id = " & mSearchID
                    mDigitalInfo = mCmd.ExecuteReader
                    With mDigitalInfo
                        If .HasRows Then
                            While .Read
                                FileSize = .GetUInt32(.GetOrdinal("file_size"))
                                rawData = New Byte(CInt(FileSize)) {}
                                .GetBytes(.GetOrdinal("file"), 0, rawData, 0, CInt(FileSize))
                                fs = New MemoryStream(rawData)
                                If CType(.Item("file_type"), String) = "emppic" Then
                                    picEmployee.Image = Image.FromStream(fs)
                                Else
                                    template = New DPFP.Template(fs)
                                    mEmployeeFP.Templates(CType(.Item("finger_position"), Integer)) = template
                                End If
                                fs.Close()
                                fs.Dispose()
                            End While
                        End If
                    End With
                    mDigitalInfo.Close()
                    mCmd.Dispose()
                    chkLLF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.LLF) Is Nothing)
                    chkLRF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.LRF) Is Nothing)
                    chkLMF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.LMF) Is Nothing)
                    chkLIF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.LIF) Is Nothing)
                    chkLTF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.LTF) Is Nothing)
                    chkRLF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.RLF) Is Nothing)
                    chkRRF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.RRF) Is Nothing)
                    chkRMF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.RMF) Is Nothing)
                    chkRIF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.RIF) Is Nothing)
                    chkRTF.Checked = Not (mEmployeeFP.Templates(clsFPID.FingerPosition.RTF) Is Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub Enroll_Finger(ByVal mFloc As Integer)
        Dim mForm As Form
        If mEmployee_ID > 0 Then
            mEmployeeFP.ID = mEmployee_ID
        End If
        mEmployeeFP.TemplateIndex = mFloc
        mForm = New frmEnrollFingerprints
        mForm.ShowDialog()
        mForm.Dispose()
    End Sub

    Private Sub chkRTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRTF.Click
        If chkRTF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.RTF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.RTF) Is Nothing) Then
                chkRTF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.RTF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkRTF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkLLF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLLF.Click
        If chkLLF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.LLF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.LLF) Is Nothing) Then
                chkLLF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.LLF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkLLF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkLRF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLRF.Click
        If chkLRF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.LRF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.LRF) Is Nothing) Then
                chkLRF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.LRF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkLRF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkLMF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLMF.Click
        If chkLMF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.LMF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.LMF) Is Nothing) Then
                chkLMF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.LMF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkLMF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkLIF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLIF.Click
        If chkLIF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.LIF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.LIF) Is Nothing) Then
                chkLIF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.LIF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkLIF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkLTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLTF.Click
        If chkLTF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.LTF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.LTF) Is Nothing) Then
                chkLTF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.LTF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkLTF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkRIF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRIF.Click
        If chkRIF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.RIF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.RIF) Is Nothing) Then
                chkRIF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.RIF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkRIF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkRMF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRMF.Click
        If chkRMF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.RMF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.RMF) Is Nothing) Then
                chkRMF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.RMF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkRMF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkRRF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRRF.Click
        If chkRRF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.RRF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.RRF) Is Nothing) Then
                chkRRF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.RRF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkRRF.Checked = True
            End If
        End If
    End Sub

    Private Sub chkRLF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRLF.Click
        If chkRLF.Checked Then
            Call Enroll_Finger(clsFPID.FingerPosition.RLF)
            If (mEmployeeFP.Templates(clsFPID.FingerPosition.RLF) Is Nothing) Then
                chkRLF.Checked = False
            End If
        Else
            If MsgBox("Are you sure you want to delete the fingerprint template?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)) = vbYes Then
                mEmployeeFP.Templates(clsFPID.FingerPosition.RLF) = Nothing
                mEmployeeFP.Changed = True
            Else
                chkRLF.Checked = True
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

        If Trim(txtLastname.Text) = "" Then
            MsgBox("Please provide a last name.", MsgBoxStyle.Information)
            txtLastname.Focus()
            btnSave.Enabled = True
            Exit Sub
        End If

        If Trim(txtFirstname.Text) = "" Then
            MsgBox("Please provide a firstname.", MsgBoxStyle.Information)
            txtFirstname.Focus()
            btnSave.Enabled = True
            Exit Sub
        End If

        If Trim(txtMiddlename.Text) = "" Then
            MsgBox("Please provide a middle name.", MsgBoxStyle.Information)
            txtMiddlename.Focus()
            btnSave.Enabled = True
            Exit Sub
        End If

        mTrans = Cn.Connection.BeginTransaction
        mTransLock = cnLock.Connection.BeginTransaction

        Try
            Dim FileSize As Long
            Dim rawData() As Byte

            mCmdLock.Transaction = mTransLock
            mCmdLock.Connection = cnLock.Connection
            mCmdLock.CommandText = "LOCK TABLES trans_lock WRITE"
            mCmdLock.ExecuteNonQuery()

            mCommand.Transaction = mTrans
            mCommand.Connection = Cn.Connection

            If mEmployee_ID = 0 Then
                mCommand.CommandText = "select employee_code from employees where employee_code = @employee_code"
            Else
                mCommand.CommandText = "select employee_code from employees where employee_code = @employee_code and employee_id <> @employee_id"
                mCommand.Parameters.AddWithValue("@employee_id", mEmployee_ID)
            End If
            mCommand.Parameters.AddWithValue("@employee_code", txtCode.Text)
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
                MsgBox("Customer code already in use.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
                Exit Sub
            Else
                rdQuery.Close()
            End If

            If mEmployee_ID = 0 Then
                mCommand.CommandText = "insert into employees (employee_code,lastname,firstname,middlename,schedule_id,department_id) values " & _
                                   "(@employee_code,@lastname,@firstname,@middlename,@schedule_id,@department_id)"
            Else
                mCommand.CommandText = "update employees set employee_code=@employee_code, lastname=@lastname,firstname=@firstname,middlename=@middlename,schedule_id=@schedule_id,department_id=@department_id " & _
                                   "where employee_id =@employee_id"
            End If
            mCommand.Parameters.AddWithValue("@lastname", txtLastname.Text)
            mCommand.Parameters.AddWithValue("@firstname", txtFirstname.Text)
            mCommand.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
            mCommand.Parameters.AddWithValue("@schedule_id", txtSchedule.Tag)
            mCommand.Parameters.AddWithValue("@department_id", txtDepartment.Tag)
            mCommand.ExecuteNonQuery()
            If mEmployee_ID = 0 Then
                mEmployee_ID = CType(mCommand.LastInsertedId, Integer)
                mCommand.Parameters.AddWithValue("@employee_id", mEmployee_ID)
            End If
            '*************************** Save picture to database ************************** 
            If mPicChange Then
                mCommand.CommandText = "delete from employee_pictures where employee_id = @employee_id"
                mCommand.ExecuteNonQuery()
                If Not (picEmployee.Image Is Nothing) Then
                    fs = New MemoryStream()
                    picEmployee.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    rawData = fs.GetBuffer()
                    FileSize = fs.Length
                    mCommand.CommandText = "insert into employee_pictures values (@employee_id,@file_size,@file)"
                    mCommand.Parameters.AddWithValue("@file_size", FileSize)
                    mCommand.Parameters.AddWithValue("@file", rawData)
                    mCommand.ExecuteNonQuery()
                    fs.Close()
                    fs.Dispose()
                End If
            End If
            '******************* Save fingerprint to directory & database ******************
            If mEmployeeFP.Changed Then
                mCommand.CommandText = "delete from employee_fingerprints where employee_id = @employee_id"
                mCommand.ExecuteNonQuery()
                With My.Computer.FileSystem
                    For i = 0 To 9
                        If Not (mEmployeeFP.Templates(i) Is Nothing) Then
                            fs = New MemoryStream()
                            mEmployeeFP.Templates(i).Serialize(fs)
                            rawData = fs.GetBuffer()
                            FileSize = fs.Length
                            mCommand.CommandText = "insert into employee_fingerprints values (@employee_id," & i & ",@file_size2" & i & ",@file2" & i & ")"
                            mCommand.Parameters.AddWithValue("@file_size2" & i, FileSize)
                            mCommand.Parameters.AddWithValue("@file2" & i, rawData)
                            mCommand.ExecuteNonQuery()
                            fs.Close()
                            fs.Dispose()
                        End If
                    Next
                End With
            End If
            '*******************************************************************************

            mTrans.Commit()

            mCmdLock.CommandText = "UNLOCK TABLES"
            mCmdLock.ExecuteNonQuery()
            mCmdLock.Dispose()
            mTransLock.Rollback()
            mCmdLock.Dispose()
            mTransLock.Dispose()

            MsgBox("Information has been succesfully saved!", MsgBoxStyle.Information)
            If MsgBox("Do you want to add new employee?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
                txtLastname.Focus()
            Else
                Call Clear_Fields()
            End If
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
        If mEmployee_ID = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to add new employee?", CType(vbQuestion + vbYesNo, MsgBoxStyle)) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call Clear_Fields()
    End Sub

    Private Sub btnCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCamera.Click
        Try
            If ofdBrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Open Image
                If Not (picEmployee.Image Is Nothing) Then
                    picEmployee.Image.Dispose()
                End If
                picEmployee.Image = Nothing
                picEmployee.Image = Image.FromFile(ofdBrowse.FileName)
                mPicChange = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnDeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePicture.Click
        If Not (picEmployee.Image Is Nothing) Then
            If MsgBox("Do you want to delete this picture?", CType(MsgBoxStyle.Question + vbYesNo, MsgBoxStyle)) = vbYes Then
                mPicChange = True
                picEmployee.Image.Dispose()
                picEmployee.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btnBrowseSchedules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSchedules.Click
        Call Get_ID("frmSchedules")
        If mSearchID > 0 Then
            Dim dtSchedules As New DataTable
            If NetOpen(dtSchedules, "select * from schedules where schedule_id=" & mSearchID) = True Then
                If dtSchedules.Rows.Count > 0 Then
                    For Each drSchedule As DataRow In dtSchedules.Rows
                        txtSchedule.Tag = mSearchID
                        txtSchedule.Text = CType(drSchedule.Item("description"), String)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnBrowseDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseDepartment.Click
        Call Get_ID("Departments")
        If mSearchID > 0 Then
            Dim dtDepartments As New DataTable
            If NetOpen(dtDepartments, "select * from departments where department_id=" & mSearchID) = True Then
                If dtDepartments.Rows.Count > 0 Then
                    For Each drSchedule As DataRow In dtDepartments.Rows
                        txtDepartment.Tag = mSearchID
                        txtDepartment.Text = CType(drSchedule.Item("description"), String)
                    Next
                End If
            End If
        End If
    End Sub
End Class