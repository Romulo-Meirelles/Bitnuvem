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

    Public Class Trades
        Inherits BitnuvemResponse

        <JsonProperty("root")>
        Public Property Result As List(Of Results)


        Class Results
            <JsonProperty("date")>
            Public Property [date] As String

            <JsonProperty("amount")>
            Public Property Valor As String

            <JsonProperty("price")>
            Public Property Preco As String

            <JsonProperty("type")>
            Public Property Tipo As String

            <JsonProperty("tid")>
            Public Property TID As String
        End Class

        'Public Function ToString() As String
        '    On Error Resume Next
        '    Dim Response As String = String.Empty

        '    For i = 0 To Result.Count - 1
        '        Response += "Data: " & Result.Item(i).date & vbCrLf
        '        Response += "Valor: " & Result.Item(i).Valor & vbCrLf
        '        Response += "Preço: " & Result.Item(i).Preco & vbCrLf
        '        Response += "Tipo: " & Result.Item(i).Tipo & vbCrLf
        '        Response += "TID: " & Result.Item(i).TID & vbCrLf & vbCrLf
        '        Response += vbCrLf
        '    Next
        '    Return Response
        ' End Function
    End Class


End Namespace