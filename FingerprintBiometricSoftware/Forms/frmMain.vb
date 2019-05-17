Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmMain

    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Private Verificator As DPFP.Verification.Verification
    Private mEmployeeFPs As clsFPIDCollection
    Dim mCtr As Integer = 0
    Dim vHost As String
    Dim vUsername As String
    Dim vPassword As String
    Dim vPort As String
    Dim vDatabase As String
    Dim isDecoded As Boolean = False
    Dim mCurrent_DateTime As DateTime
    Dim mEmpID As Integer

    Private Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                          ' Subscribe for capturing events.
            Else
                'SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        mEmployeeFPs = New clsFPIDCollection
    End Sub

    Private Sub Process(ByVal Sample As DPFP.Sample)
        If mEmployeeFPs.SampleVerified(Sample) = True Then
            Dim dtCurrentDateTime As New DataTable
            If NetOpen(dtCurrentDateTime, "select now() current_datetime") = True Then
                If dtCurrentDateTime.Rows.Count > 0 Then
                    For Each mRow As DataRow In dtCurrentDateTime.Rows
                        mCurrent_DateTime = CType(mRow.Item("current_datetime"), DateTime)
                    Next
                End If
            End If
            If mEmpID = CType(mEmployeeFPs.EmployeeID, Integer) Then
                If gbxEmployeeInfo.Visible Then
                    Exit Sub
                End If
            End If
            mEmpID = CType(mEmployeeFPs.EmployeeID, Integer)
            Call StopCapture()
            Call DisplayInfo(mEmpID)
        Else
            Call StopCapture()
        End If
        Call StartCapture()
    End Sub

    Private Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Private Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                'SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                'SetPrompt("Can't initiate capture!")
            End Try
        End If
    End Sub

    Private Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                'SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub

    Private Sub CaptureForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        StopCapture()
    End Sub

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        'MakeReport("The fingerprint sample was captured.")
        'SetPrompt("Scan the same fingerprint again.")
        Call Process(Sample)
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        'MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        'MakeReport("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        'MakeReport("The fingerprint reader was disconnected.")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            'MakeReport("The quality of the fingerprint sample is good.")
        Else
            'MakeReport("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If gbxEmployeeInfo.Visible = True Then
            pb.Value = 100 - mCtr
            mCtr += 1
        End If
        If mCtr > 100 Then
            gbxEmployeeInfo.Visible = False
            lblNotice.Text = "Place your finger on the scanner."
            mCtr = 0
        End If
        lblTime.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'lblDate.Text = Format(Now, "dddd") & vbCrLf & Format(Now, "MMMM dd") & vbCrLf & Format(Now, "yyyy")
        lblDate.Text = Format(Now, "dddd") & ", " & Format(Now, "MMMM dd") & ", " & Format(Now, "yyyy")
        lblTime.Text = ""
        Cn = New clsConnectionDetails
        Cn.ConnectToServer()
        If Cn.IsConnected = True Then
            cnLock = New clsConnectionDetails
            cnLock.ConnectToServer()
            Call RefreshInfo()
            Init()
            StartCapture()
        Else
            lblNotice.Text = "Database connection error!"
            lblNotice.ForeColor = Color.Red
        End If
        'MsgBox(DateDiff("s", #6/8/2013 12:00:30 AM#, #6/8/2013 12:00:40 AM#))
    End Sub

    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        Call StopCapture()
        Call Hide()
        Dim mForm As Form
        mForm = New frmConnectionSettings
        mForm.ShowDialog()
        mForm.Dispose()
        If Cn.IsConnected = True Then
            lblNotice.Text = "Place your finger on top of the scanner."
            lblNotice.ForeColor = Color.White
        End If
        Call Show()
        Call StopCapture()
    End Sub

    Private Sub btnAdminTasks_Click(sender As System.Object, e As System.EventArgs) Handles btnAdminTasks.Click
        Call StopCapture()
        Call Hide()
        Dim mForm As Form
        mForm = New frmSecurityVerification
        mForm.ShowDialog()
        mForm.Dispose()
        Call Show()
        Call StartCapture()
    End Sub

    Private Sub TestDecoding()
        Dim wrapper As New clsSimple3Des("un1quep@ssw0rd")
        Try
            Dim cipherText As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\strct.dat")
            Dim plainText As String = wrapper.DecryptData(cipherText)
            Call RetrieveText(plainText) 'rearrange data to match the connection settings
            'Initialize Connection Information in StatusStrip
            'Call SetConnectInfo(vHost, vDatabase, "                        ")
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.", MsgBoxStyle.Exclamation, ex.Message)
            'Initialize Connection Information in StatusStrip
            'Call SetConnectInfo("                        ", "                        ", "                        ")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "An error occured!")
            'Call SetConnectInfo("                        ", "                        ", "                        ")
        End Try
    End Sub

    Private Sub RetrieveText(ByVal vString As String)
        Dim ctr As Integer
        Dim i As Integer
        Dim charsInFile As Integer
        Dim letter As String
        Dim Decrypt As String = ""
        vHost = ""
        vUsername = ""
        vPassword = ""
        vPort = ""
        vDatabase = ""
        charsInFile = vString.Length 'get length of string
        For i = 0 To charsInFile - 1 'loop once for each char
            letter = vString.Substring(i, 1) 'get character
            If letter = "|" Then
                letter = ""
                ctr = ctr + 1
                If ctr = 1 Then
                    vHost = Decrypt
                    Decrypt = ""
                ElseIf ctr = 2 Then
                    vUsername = Decrypt
                    Decrypt = ""
                ElseIf ctr = 3 Then
                    vPassword = Decrypt
                    Decrypt = ""
                ElseIf ctr = 4 Then
                    vPort = Decrypt
                    Decrypt = ""
                End If
            End If
            Decrypt = Decrypt & letter
        Next i 'and build new string
        vDatabase = Decrypt
        Decrypt = ""
    End Sub

    Private Sub DisplayInfo(ByVal mEmp_ID As Object)
        Invoke(New FunctionCall(AddressOf _DisplayInfo), mEmp_ID)
    End Sub

    Private Sub _DisplayInfo(ByVal mEmp_ID As Object)
        Dim dtEmployee As New DataTable
        If NetOpen(dtEmployee, "select * from employees where employee_id =" & CType(mEmp_ID, Integer)) = True Then
            If dtEmployee.Rows.Count > 0 Then
                Dim mTrans As MySqlTransaction
                Dim mDigitalInfo As MySqlDataReader
                Dim mCmd As New MySqlCommand
                Dim rawData() As Byte
                Dim FileSize As UInt32
                Dim fs As New MemoryStream()
                Dim mLogStatus As String = ""
                Dim mColStatus As Integer
                Dim mCurrentDateLog As DateTime
                gbxEmployeeInfo.Visible = False
                mTrans = Cn.Connection.BeginTransaction
                For Each drEmployee As DataRow In dtEmployee.Rows
                    lblFullname.Text = CType(drEmployee.Item("lastname"), String) & ", "
                    lblFullname.Text &= CType(drEmployee.Item("firstname"), String) & " "
                    lblFullname.Text &= CType(drEmployee.Item("middlename"), String)
                    mLogStatus = CType(IIf(drEmployee.Item("logstatus").ToString = "O", "I", "O"), String)
                    mColStatus = CType(drEmployee.Item("colstatus"), Integer)
                    mCurrentDateLog = CType(drEmployee.Item("currentdatelog"), DateTime)
                Next
                mCmd.Transaction = mTrans
                mCmd.Connection = Cn.Connection

                'If mLogStatus = "I" Then
                '    If mCurrentDateLog.ToShortDateString <> mCurrent_DateTime.ToShortDateString Then
                '        mColStatus = 1
                '    Else
                '        mColStatus += 1
                '    End If
                'Else
                '    mColStatus += 1
                'End If
                'If mColStatus <= 6 Then
                '    mCmd.CommandText = "update employees set logstatus = '" & mLogStatus & "', " & _
                '                        "colstatus=" & mColStatus & ",datetimelog='" & Format(mCurrent_DateTime, "yyyy-MM-dd HH:mm:ss") & "' " & _
                '                        "where employee_id = " & CType(mEmp_ID, String)
                '    mCmd.ExecuteNonQuery()
                '    If mColStatus = 1 Then
                '        mCmd.CommandText = "insert into employee_dtrs (employee_id,work_date,log1) values " & _
                '                            "(" & CType(mEmp_ID, String) & "," & _
                '                            "'" & Format(mCurrent_DateTime, "yyyy-MM-dd") & "'," & _
                '                            "'" & Format(mCurrent_DateTime, "yyyy-MM-dd HH:mm:ss") & "')"
                '        mCmd.ExecuteNonQuery()
                '        mCmd.CommandText = "update employees set currentdatelog='" & Format(mCurrent_DateTime, "yyyy-MM-dd") & "' " & _
                '                            "where employee_id = " & CType(mEmp_ID, String)
                '        mCmd.ExecuteNonQuery()
                '    Else
                '        mCmd.CommandText = "update employee_dtrs set log" & mColStatus & " = '" & Format(mCurrent_DateTime, "yyyy-MM-dd HH:mm:ss") & "'" & _
                '                           "where employee_id=" & CType(mEmp_ID, String) & " and " & _
                '                           "work_date=(select date(currentdatelog) from employees where employee_id = " & CType(mEmp_ID, String) & ")"
                '        mCmd.ExecuteNonQuery()
                '    End If

                '    lblInOut.Text = CType(IIf(mLogStatus = "I", "IN", "OUT"), String)
                '    lblTimeLog.Text = Format(mCurrent_DateTime, "hh:mm tt")
                '    'lblNotice.Text = CType(IIf(mLogStatus = "I", "IN", "OUT"), String) & " (" & Format(mCurrent_DateTime, "hh:mm tt") & ")"
                'Else
                '    lblInOut.Text = "Invalid"
                '    lblTimeLog.Text = "DTR is full."
                'End If

                mLogStatus = CType(IIf(btnStatus.Text = "OUT", "0", "1"), String)
                lblInOut.Text = CType(IIf(mLogStatus = "1", "IN", "OUT"), String)
                lblTimeLog.Text = Format(mCurrent_DateTime, "hh:mm tt")

                mCmd.CommandText = "update employees set logstatus = '" & mLogStatus & "', " & _
                                    "datetimelog='" & Format(mCurrent_DateTime, "yyyy-MM-dd HH:mm:ss") & "' " & _
                                    "where employee_id = " & CType(mEmp_ID, String)
                mCmd.ExecuteNonQuery()

                mCmd.CommandText = "insert into employee_logs (employee_id,datetime_log,log_status) values " & _
                                    "(" & CType(mEmp_ID, String) & ",'" & Format(mCurrent_DateTime, "yyyy-MM-dd HH:mm:ss") & "','" & mLogStatus & "')"
                mCmd.ExecuteNonQuery()

                mCmd.CommandText = "select * from employee_pictures where employee_id = " & CType(mEmp_ID, String)
                mDigitalInfo = mCmd.ExecuteReader
                With mDigitalInfo
                    If .HasRows Then
                        While .Read
                            FileSize = .GetUInt32(.GetOrdinal("file_size"))
                            rawData = New Byte(CInt(FileSize)) {}
                            .GetBytes(.GetOrdinal("file"), 0, rawData, 0, CInt(FileSize))
                            fs = New MemoryStream(rawData)
                            picEmployee.Image = Image.FromStream(fs)
                            fs.Close()
                            fs.Dispose()
                        End While
                    End If
                End With

                mDigitalInfo.Close()
                mCmd.Dispose()
                mTrans.Commit()
                mCtr = 0
                pb.Value = 100
                gbxEmployeeInfo.Visible = True
                Call RefreshInfo()
            End If
        End If
    End Sub

    Private Sub RefreshInfo()
        Dim myData As New DataTable
        If NetOpen(myData, "select ucase(concat(lastname,', ',firstname,' ',middlename)) employee_name,IF(logstatus='1','IN','OUT') logstatus  from employees where date(datetimelog)=date(now()) order by datetimelog desc", Cn.Connection) = True Then
            dgvList.DataSource = myData
        End If
    End Sub

    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        If btnStatus.Text = "OUT" Then
            btnStatus.Text = "IN"
            btnStatus.ForeColor = Color.DarkGreen
        Else
            btnStatus.Text = "OUT"
            btnStatus.ForeColor = Color.Red
        End If
    End Sub
End Class
