Imports Newtonsoft.Json

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
    Public Class BalanceResponse
        Inherits BitnuvemResponse
        <JsonProperty("total")>
        Public Property total As total_

        <JsonProperty("available")>
        Public Property available As available_

        <JsonProperty("in_use")>
        Public Property in_use As in_use_

        Public Class total_
            <JsonProperty("REAL")>
            Public Property REAL As String
            <JsonProperty("BTC")>
            Public Property BTC As String
        End Class
        Public Class available_
            <JsonProperty("REAL")>
            Public Property REAL As String
            <JsonProperty("BTC")>
            Public Property BTC As String
        End Class

        Public Class in_use_
            <JsonProperty("REAL")>
            Public Property REAL As String
            <JsonProperty("BTC")>
            Public Property BTC As String
        End Class

        Public Overrides Function ToString() As String
            Return "Total:" & vbCrLf &
                    "Real: " & total.REAL & vbCrLf &
                    "BTC: " & total.BTC & vbCrLf & vbCrLf &
                    "Disponível: " & vbCrLf &
                    "Real: " & available.REAL & vbCrLf &
                    "BTC: " & available.BTC & vbCrLf & vbCrLf &
                    "Em Uso: " & vbCrLf &
                    "Real: " & in_use.REAL & vbCrLf &
                    "BTC: " & in_use.BTC & vbCrLf & vbCrLf
        End Function
    End Class
End Namespace
