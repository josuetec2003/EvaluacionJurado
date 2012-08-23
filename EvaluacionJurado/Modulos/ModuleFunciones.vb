Imports System.Data
Imports System.Data.SqlClient

Module ModuleFunciones
    Public Function SHA1(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Public Function Mandar_a_ProbarConexion() As Boolean
        Try
            If ValidarConexion(My.Settings.JuradoFestivalConnectionString) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            Return False
        End Try
    End Function

    Public Function ValidarConexion(ByVal CadenaConexion As String) As Boolean
        Dim _CNNSeg As New SqlConnection(CadenaConexion)
        Using _CNNSeg
            _CNNSeg.Open()
        End Using
        Return True
    End Function
End Module
