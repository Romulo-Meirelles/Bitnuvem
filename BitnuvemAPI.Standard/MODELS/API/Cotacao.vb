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
    Public Class Cotacao
        Inherits BitnuvemResponse

        <JsonProperty("code")>
        Public Property Code As String

        <JsonProperty("data")>
        Public Property Data As Cot

        Class Cot
            <JsonProperty("cotacao")>
            Public Property Cotacao As Result

            Class Result
                <JsonProperty("ultimo")>
                Public Property Ultimo As String

                <JsonProperty("variacao_24_horas")>
                Public Property Variacao_24h As String

                <JsonProperty("valor_dolar")>
                Public Property Valor_Dolar As String

                <JsonProperty("valor_btc_dolar")>
                Public Property Valor_BTC_Dolar As String

                <JsonProperty("valor_dolar_btc")>
                Public Property Valor_Dolar_BTC As String

                <JsonProperty("valor_dolar_btc_diferenca")>
                Public Property Valor_Diferenca_Dolar_BTC As String

                <JsonProperty("volume_24_horas")>
                Public Property Volume_24h As String
            End Class
        End Class
        Public Overrides Function ToString() As String
            Return "Último: " & Data.Cotacao.Ultimo & vbCrLf &
                   "Variação 24h: " & Data.Cotacao.Variacao_24h & vbCrLf &
                   "Valor Dolar: " & Data.Cotacao.Valor_Dolar & vbCrLf &
                   "Valor BTC x Dolar: " & Data.Cotacao.Valor_BTC_Dolar & vbCrLf &
                   "Valor Dolar x BTC: " & Data.Cotacao.Valor_Dolar_BTC & vbCrLf &
                   "Valor Dolar x BTC Diferença: " & Data.Cotacao.Valor_Diferenca_Dolar_BTC & vbCrLf &
                   "Volume 24h: " & Data.Cotacao.Volume_24h & vbCrLf
        End Function
    End Class
End Namespace