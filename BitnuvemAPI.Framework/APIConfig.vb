
Namespace Bitnuvem
    ''' <summary>
    ''' *** MADE FOR GITHUB ***
    ''' WRITTEN BY ROMULO MEIRELLES.
    ''' UPWORK: https://www.upwork.com/freelancers/~01fcbc5039ac5766b4
    ''' CONTACT WHATSAPP: https://wa.me/message/KWIS3BYO6K24N1
    ''' CONTACT TELEGRAM: https://t.me/Romulo_Meirelles
    ''' GITHUB: https://github.com/Romulo-Meirelles
    ''' DISCORD: đąяķňέs§¢øďε#2786
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Class ApiConfig
        Public Property ApiKey As String
        Public Property SecretKey As String
        Public Property BaseUrlTRADEAPI As String = "https://bitnuvem.com/tapi/"
        Public Property BaseUrlAPI As String = "https://bitnuvem.com/api/BTC/"
        Public Property BaseUrlWS As String = "https://bitnuvem.com/ws/"
        Public Property SendInterceptors As IEnumerable(Of IBalanceInterceptor) = Array.Empty(Of IBalanceInterceptor)()
        Public Sub Check()
            If String.IsNullOrEmpty(ApiKey) Then Throw New ArgumentException("The API key is missing.", NameOf(ApiConfig.ApiKey))
        End Sub
    End Class
End Namespace
