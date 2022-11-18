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
    Public Class OrderBook
        Inherits BitnuvemResponse

        <JsonProperty("bids")>
        Public Property bids As List(Of List(Of Object))

        <JsonProperty("asks")>
        Public Property asks As List(Of List(Of Object))

        Public Overrides Function ToString() As String
            Dim Books As String = String.Empty
            Books += "Preço da Oferta: " & vbCrLf
            For i = 0 To bids.Count - 1
                Books += bids.Item(i).Item(0).ToString & " | " & bids.Item(i).Item(1).ToString & vbCrLf
            Next

            Books += vbCrLf & "Quantia Total da Oferta: " & vbCrLf
            For i = 0 To asks.Count - 1
                Books += asks.Item(i).Item(0).ToString & " | " & asks.Item(i).Item(1).ToString & vbCrLf
            Next

            Return Books
        End Function
    End Class
End Namespace