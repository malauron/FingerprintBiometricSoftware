Public NotInheritable Class clsFPID

    Public Enum FingerPosition
        LLF = 0
        LRF = 1
        LMF = 2
        LIF = 3
        LTF = 4
        RLF = 5
        RRF = 6
        RMF = 7
        RIF = 8
        RTF = 9
    End Enum

    Public Templates(9) As DPFP.Template
    Private Verificator As New DPFP.Verification.Verification
    Private mID As Integer = 0
    Private mTemplateIndex As Integer = 0
    Private mChanged As Boolean

    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property

    Public Property TemplateIndex() As Integer
        Get
            Return mTemplateIndex
        End Get
        Set(ByVal value As Integer)
            mTemplateIndex = value
        End Set
    End Property

    Public Property Changed() As Boolean
        Get
            Return mChanged
        End Get
        Set(ByVal value As Boolean)
            mChanged = value
        End Set
    End Property

    Public Sub ClearAllTemplates()
        mID = 0
        For i = 0 To 9
            Templates(i) = Nothing
        Next
    End Sub

    Private Sub ClearTemplate(ByVal mIndex As Integer)
        Templates(mIndex) = Nothing
    End Sub

    Public Function SampleVerified(ByVal Sample As DPFP.Sample) As Boolean
        Dim mVerified As Boolean = False
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)
        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then
            ' Compare the feature set with our template
            Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
            For Each Template As DPFP.Template In Templates
                If Not (Template Is Nothing) Then
                    Verificator.Verify(features, Template, result)
                    If result.Verified Then
                        mVerified = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return mVerified
    End Function

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

End Class
