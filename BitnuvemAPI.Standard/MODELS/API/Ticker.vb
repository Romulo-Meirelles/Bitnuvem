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
    Public Class Ticker
        Inherits BitnuvemResponse

        <JsonProperty("ticker")>
        Public Property ticker As Order


        Class Order
            <JsonProperty("high")>
            Public Property High As String

            <JsonProperty("low")>
            Public Property Low As String

            <JsonProperty("vol")>
            Public Property Volume As String

            <JsonProperty("last")>
            Public Property Last As String

            <JsonProperty("buy")>
            Public Property Buy As String

            <JsonProperty("sell")>
            Public Property Sell As String

            <JsonProperty("date")>
            Public Property Data As String
        End Class


        Public Overrides Function ToString() As String
            Return "Máxima: " & ticker.High & vbCrLf &
                   "Mínima: " & ticker.Low & vbCrLf &
                   "Volume: " & ticker.Volume & vbCrLf &
                   "Último: " & ticker.Last & vbCrLf &
                   "Compra: " & ticker.Buy & vbCrLf &
                   "Venda: " & ticker.Sell & vbCrLf &
                   "Data: " & ticker.Data & vbCrLf
        End Function
    End Class
End Namespace