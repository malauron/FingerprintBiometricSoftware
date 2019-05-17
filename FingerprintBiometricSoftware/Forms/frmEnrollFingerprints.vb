Delegate Sub FunctionCall(ByVal param As Object)

Public Class frmEnrollFingerprints
    Implements DPFP.Capture.EventHandler
    Private Template As DPFP.Template
    Private Capturer As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    Private mFPs As clsFPIDCollection

    Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                          ' Subscribe for capturing events.
            Else
                Call SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Enroller = New DPFP.Processing.Enrollment()                 ' Create an enrollment.
        Call UpdateStatus("")
        mFPs = New clsFPIDCollection
    End Sub

    Sub Process(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        If mEmployeeFP.SampleVerified(Sample) Then
            MsgBox("Fingerprint already registered.", MsgBoxStyle.Exclamation)
            Call StopCapture()
            Call StartCapture()
            Exit Sub
        End If
        If mFPs.SampleVerified(Sample, mEmployeeFP.ID) = True Then
            MsgBox("Fingerprint already registered.", MsgBoxStyle.Exclamation)
            Call StopCapture()
            Call StartCapture()
            Exit Sub
        End If
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                Call MakeReport("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)                      ' Add feature set to template.
            Catch ex As DPFP.Error.SDKException
                Call UpdateStatus("")
                Enroller.Clear()
                Call StopCapture()
                Call OnTemplate(Nothing)
                Call StartCapture()
                Exit Sub
            End Try
            Call UpdateStatus("")
            ' Check if template has been created.
            Select Case Enroller.TemplateStatus
                Case DPFP.Processing.Enrollment.Status.Ready        ' Report success and stop capturing
                    Call OnTemplate(Enroller.Template)
                    Call SetPrompt("Fingerprint template is ready.")
                    Call StopCapture()
                    Call SaveFPTemplate("")
                Case DPFP.Processing.Enrollment.Status.Failed       ' Report failure and restart capturing
                    Enroller.Clear()
                    Call StopCapture()
                    Call OnTemplate(Nothing)
                    Call StartCapture()
            End Select
        End If
    End Sub

    Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()        ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)                  ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
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
                Call SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                Call SetPrompt("Can't initiate capture!")
            End Try
        End If
    End Sub

    Private Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                Call SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub

    Private Sub frmMDFPRegistration_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call StopCapture()
    End Sub

    Private Sub frmMDFPRegistration_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frmMDFPRegistration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Init()
        Call StartCapture()
    End Sub

    Private Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Call MakeReport("The fingerprint sample was captured.")
        Call SetPrompt("Scan the same fingerprint again.")
        Call Process(Sample)
    End Sub

    Private Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Private Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        Call MakeReport("The fingerprint reader was touched.")
    End Sub

    Private Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        Call MakeReport("The fingerprint reader was connected.")
    End Sub

    Private Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        Call MakeReport("The fingerprint reader was disconnected.")
    End Sub

    Private Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            Call MakeReport("The quality of the fingerprint sample is good.")
        Else
            Call MakeReport("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Protected Sub SetPrompt(ByVal text As Object)
        Invoke(New FunctionCall(AddressOf _SetPrompt), text)
    End Sub

    Private Sub _SetPrompt(ByVal text As Object)
        txtPrompt.Text = CStr(text)
    End Sub

    Protected Sub MakeReport(ByVal status As Object)
        Invoke(New FunctionCall(AddressOf _MakeReport), status)
    End Sub

    Private Sub _MakeReport(ByVal status As Object)
        txtStatus.AppendText(CStr(status) & Chr(13) & Chr(10))
    End Sub

    Protected Sub DrawPicture(ByVal bmp As Object)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp As Object)
        Picture.Image = New Bitmap(CType(bmp, Image), Picture.Size)
    End Sub

    Private Sub frmMDFPRegistration_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With lblTitle
            .Top = 0
            .Left = 0
            .Width = Me.Width
        End With
        With gbxMain
            .Top = lblTitle.Top + lblTitle.Height
            .Left = 3
        End With
    End Sub

    Private Sub OnTemplate(ByVal template As Object)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub

    Private Sub _OnTemplate(ByVal template As Object)
        Me.Template = CType(template, DPFP.Template)
        If Not template Is Nothing Then
            MsgBox("Fingerprint template created.", MsgBoxStyle.Information, "Fingerprint Enrollment")
        Else
            Call UpdateStatus("")
            MsgBox("The fingerprint template is not valid. Repeat fingerprint enrollment.", MsgBoxStyle.Exclamation, "Fingerprint Enrollment")
        End If
    End Sub

    Private Sub UpdateStatus(ByVal mED As Object)
        Invoke(New FunctionCall(AddressOf _UpdateStatus), mED)
    End Sub

    Private Sub _UpdateStatus(ByVal mED As Object)
        ' Show number of samples needed.
        Select Case Enroller.FeaturesNeeded
            Case 3
                pic1.Image = picMain.Image
            Case 2
                Pic2.Image = picMain.Image
            Case 1
                Pic3.Image = picMain.Image
            Case 0
                Pic4.Image = picMain.Image
                btnSave.Enabled = True
            Case Else
                pic1.Image = Nothing
                Pic2.Image = Nothing
                Pic3.Image = Nothing
                Pic4.Image = Nothing
                Picture.Image = Nothing
                btnSave.Enabled = False
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        mEmployeeFP.Templates(mEmployeeFP.TemplateIndex) = Me.Template
        mEmployeeFP.Changed = True
        Me.Close()
    End Sub

    Private Sub SaveFPTemplate(ByVal mED As Object)
        Invoke(New FunctionCall(AddressOf _SaveFPTemplate), mED)
    End Sub

    Private Sub _SaveFPTemplate(ByVal mED As Object)
        mEmployeeFP.Templates(mEmployeeFP.TemplateIndex) = Me.Template
        mEmployeeFP.Changed = True
        Me.Close()
    End Sub
End Class