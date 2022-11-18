Imports System.Security.Cryptography
Namespace Bitnuvem
    Public Class HMAC256
        Public Function Create_HMACSHA256_Sign(ByVal Message As String, ByVal SecretKey As String) As String
            Try
                Dim Encoding = New Text.ASCIIEncoding()
                Dim KeyByte As Byte() = Encoding.GetBytes(SecretKey)
                Dim MessageBytes As Byte() = Encoding.GetBytes(Message)
                Using Hmacsha256 = New HMACSHA256(KeyByte)
                    Dim HashBytes As Byte() = Hmacsha256.ComputeHash(MessageBytes)
                    Return BitConverter.ToString(HashBytes).Replace("-", "").ToLower()
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace