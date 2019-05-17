Imports MySql.Data.MySqlClient
Imports System.IO

Public NotInheritable Class clsFPIDCollection

    Private mEmployeeID As Integer = 0
    Private mEmployeeIDs() As String
    Private mFPIDs() As DPFP.Template
    Private mHasFPs As Boolean = False
    Private Verificator As DPFP.Verification.Verification

    Public Sub New()
        Dim mDigitalInfo As MySqlDataReader
        Dim mCmd As New MySqlCommand
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As New MemoryStream()
        Dim I As Integer = 0
        Try
            mCmd.Connection = Cn.Connection
            mCmd.CommandText = "select employee_id,finger_position,file_size,file from employee_fingerprints "
            mDigitalInfo = mCmd.ExecuteReader
            With mDigitalInfo
                If .HasRows Then
                    While .Read
                        ReDim Preserve mFPIDs(I)
                        ReDim Preserve mEmployeeIDs(I)
                        FileSize = .GetUInt32(.GetOrdinal("file_size"))
                        rawData = New Byte(CInt(FileSize)) {}
                        .GetBytes(.GetOrdinal("file"), 0, rawData, 0, CInt(FileSize))
                        fs = New MemoryStream(rawData)
                        mFPIDs(I) = New DPFP.Template(fs)
                        mEmployeeIDs(I) = CType(.Item("employee_id"), String)
                        fs.Close()
                        fs.Dispose()
                        I += 1
                    End While
                End If
            End With
            mDigitalInfo.Close()
            mDigitalInfo = Nothing
            mCmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        
        If I > 0 Then
            mHasFPs = True
            Verificator = New DPFP.Verification.Verification()
        End If
    End Sub

    Public Function SampleVerified(ByVal Sample As DPFP.Sample, Optional mExemptedID As Integer = 0) As Boolean
        Dim mVerified As Boolean = False
        If mHasFPs Then
            Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)
            ' Check quality of the sample and start verification if it's good
            If Not features Is Nothing Then
                ' Compare the feature set with our template
                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                For i As Integer = 0 To mFPIDs.Length - 1
                    If CType(mEmployeeIDs(i), Integer) <> mExemptedID Then
                        Verificator.Verify(features, mFPIDs(i), result)
                        If result.Verified Then
                            mVerified = True
                            mEmployeeID = CType(mEmployeeIDs(i), Integer)
                            Exit For
                        End If
                    End If
                Next
            End If
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

    Public ReadOnly Property EmployeeID() As Integer
        Get
            Return mEmployeeID
        End Get
    End Property

End Class
