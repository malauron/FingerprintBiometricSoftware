Imports MySql.Data.MySqlClient

Public NotInheritable Class clsConnectionDetails

    Private vHost As String
    Private vUsername As String
    Private vPassword As String
    Private vPort As String
    Private vDatabase As String
    Private vException As String

    Private vIsConnected As Boolean

    Private vConnection As MySqlConnection

    Public Function Host() As String
        Return vHost
    End Function

    Public Function Username() As String
        Return vUsername
    End Function

    Public Function Password() As String
        Return vPassword
    End Function

    Public Function Port() As String
        Return vPort
    End Function

    Public Function Database() As String
        Return vDatabase
    End Function

    Public Function IsConnected() As Boolean
        Return vIsConnected
    End Function

    Public Function Exception() As String
        Return vException
    End Function

    Public Function Connection() As MySqlConnection
        Return vConnection
    End Function

    Public Sub ConnectToServer(Optional mHost As String = "", Optional mUsername As String = "", Optional mPassword As String = "", _
                               Optional mPort As String = "", Optional mDatabase As String = "")

        vIsConnected = False
       
        If Trim(mHost) = "" Or Trim(mUsername) = "" Or Trim(mPassword) = "" Or Trim(mPort) = "" Or Trim(mDatabase) = "" Then
            If CredentialsDecoded() = False Then
                Exit Sub
            End If
        Else
            vHost = mHost
            vUsername = mUsername
            vPassword = mPassword
            vPort = mPort
            vDatabase = mDatabase
        End If

        vConnection = Nothing
        vConnection = New MySqlConnection

        vConnection.ConnectionString = "Server=" & vHost & ";" _
                & "Uid=" & vUsername & ";" _
                & "Pwd=" & vPassword & ";" _
                & "Port=" & vPort & ";" _
                & "database=" & vDatabase & ""

        Try
            vConnection.Open()
            vIsConnected = True
        Catch myerror As MySqlException
            vException = myerror.Message
        Catch myerror As Exception
            vException = myerror.Message
        End Try

    End Sub

    Private Function CredentialsDecoded() As Boolean
        Dim mDecoded As Boolean = False
        Dim wrapper As New clsSimple3Des("un1quep@ssw0rd")
        Try
            Dim cipherText As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\strct.dat")
            Dim plainText As String = wrapper.DecryptData(cipherText)
            Call RetrieveText(plainText) 'rearrange data to match the connection settings
            mDecoded = True
        Catch ex As Exception
        End Try
        Return mDecoded
    End Function

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

    Public Sub EncodeCredentials()

        Dim plainText As String
        plainText = vHost & "|" & vUsername & "|" & vPassword & "|" & vPort & "|" & vDatabase
        Dim wrapper As New clsSimple3Des("un1quep@ssw0rd") ' you can put anything in the parameter of clsSimple3Des class 
        Dim cipherText As String = wrapper.EncryptData(plainText)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\strct.dat", cipherText, False)
        MsgBox("Database connection settings successfully saved.", MsgBoxStyle.Information, "Database connection setup.")

    End Sub

End Class
