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
    Public Class Order_Get
        Inherits BitnuvemResponse

        <JsonProperty("root")>
        Public Property Result As List(Of Results)

        Class Results
            <JsonProperty("id")>
            Public Property Id As String

            <JsonProperty("create")>
            Public Property Criado As String

            <JsonProperty("mode")>
            Public Property Modo As String

            <JsonProperty("type")>
            Public Property Tipo As String

            <JsonProperty("status")>
            Public Property Status As String

            <JsonProperty("amount")>
            Public Property Quantidade As String

            <JsonProperty("price")>
            Public Property Preco As String

            <JsonProperty("total")>
            Public Property Total As String

            <JsonProperty("amount_executed")>
            Public Property Quantidade_Executada As String

            <JsonProperty("orders_executed")>
            Public Property Ordens_Executadas As List(Of OrderExecuted)

            Class OrderExecuted
                <JsonProperty("date")>
                Public Property Criado As String

                <JsonProperty("price")>
                Public Property Preco As String

                <JsonProperty("amount")>
                Public Property Quantidade As String
            End Class

            <JsonProperty("trigger")>
            Public Property Gatilho As String

            <JsonProperty("trigger_price")>
            Public Property Preco_Gatilho As String

        End Class

        Public Overrides Function ToString() As String
            On Error Resume Next
            Dim Response As String = String.Empty

            For i = 0 To Result.Count - 1
                Response += "ID: " & Result.Item(i).Id & vbCrLf
                Response += "Criado: " & Result.Item(i).Criado & vbCrLf
                Response += "Modo: " & Result.Item(i).Modo & vbCrLf
                Response += "Tipo: " & Result.Item(i).Tipo & vbCrLf
                Response += "Status: " & Result.Item(i).Status & vbCrLf
                Response += "Quantidade: " & Result.Item(i).Quantidade & vbCrLf
                Response += "Preço: " & Result.Item(i).Preco & vbCrLf
                Response += "Total: " & Result.Item(i).Total & vbCrLf
                Response += "Quantidade Executada: " & Result.Item(i).Quantidade_Executada & vbCrLf
                Response += "Gatilho: " & Result.Item(i).Gatilho & vbCrLf
                Response += "Preco Gatilho: " & Result.Item(i).Preco_Gatilho & vbCrLf
                Response += "----- Ordens Executadas -----" & vbCrLf

                For h = 0 To Result.Item(i).Ordens_Executadas.Count - 1
                    Response += "Criado: " & Result.Item(i).Ordens_Executadas(h).Criado & vbCrLf
                    Response += "Preço: " & Result.Item(i).Ordens_Executadas(h).Preco & vbCrLf
                    Response += "Quantidade: " & Result.Item(i).Ordens_Executadas(h).Quantidade & vbCrLf
                Next
                Response += vbCrLf
            Next
            Return Response
        End Function
    End Class
End Namespace