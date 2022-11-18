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
    Public Class TradeAdvanced
        Inherits BitnuvemResponse

        <JsonProperty("code")>
        Public Property Code As String

        <JsonProperty("data")>
        Public Property Data As DataBook

        Class DataBook
            <JsonProperty("data_book")>
            Public Property DataBook As String

            <JsonProperty("livro_ofertas")>
            Public Property Livro_Ofertas As LivrodeOfertas

            Class LivrodeOfertas
                <JsonProperty("compra")>
                Public Property Compras As Compras_

                <JsonProperty("venda")>
                Public Property Vendas As Vendas_

                <JsonProperty("info")>
                Public Property Informacoes As Info_

                Class Compras_
                    <JsonProperty("melhor")>
                    Public Property Melhor As String

                    <JsonProperty("total")>
                    Public Property Total As String

                    <JsonProperty("ordens")>
                    Public Property Ordens As List(Of Ordens_)

                    Class Ordens_
                        <JsonProperty("data")>
                        Public Property Data As String

                        <JsonProperty("ordem_nova")>
                        Public Property Ordem_Nova As String

                        <JsonProperty("quantidade")>
                        Public Property Quantidade As String

                        <JsonProperty("valor_btc")>
                        Public Property Valor_BTC As String

                        <JsonProperty("total")>
                        Public Property Total As String

                        <JsonProperty("relevancia")>
                        Public Property Relevancia As String
                    End Class
                End Class

                Class Vendas_
                    <JsonProperty("melhor")>
                    Public Property Melhor As String

                    <JsonProperty("total")>
                    Public Property Total As String

                    <JsonProperty("ordens")>
                    Public Property Ordens As List(Of Ordens_)

                    Class Ordens_
                        <JsonProperty("data")>
                        Public Property Data As String

                        <JsonProperty("ordem_nova")>
                        Public Property Ordem_Nova As String

                        <JsonProperty("quantidade")>
                        Public Property Quantidade As String

                        <JsonProperty("valor_btc")>
                        Public Property Valor_BTC As String

                        <JsonProperty("total")>
                        Public Property Total As String

                        <JsonProperty("relevancia")>
                        Public Property Relevancia As String
                    End Class
                End Class

                Class Info_
                    <JsonProperty("spread")>
                    Public Property Spread As Spread_

                    <JsonProperty("min")>
                    Public Property Minimo As String

                    <JsonProperty("max")>
                    Public Property Maximo As String


                    Class Spread_
                        <JsonProperty("porcentagem")>
                        Public Property Porcentagem As String

                        <JsonProperty("valor")>
                        Public Property Valor As String
                    End Class
                End Class

            End Class

            <JsonProperty("ultimas")>
            Public Property Ultimas As List(Of Ultimas_)

            Class Ultimas_
                <JsonProperty("tipo")>
                Public Property Tipo As String

                <JsonProperty("data")>
                Public Property Data As String

                <JsonProperty("quantidade")>
                Public Property Quantidade As String

                <JsonProperty("preco")>
                Public Property Preco As String

                <JsonProperty("valor")>
                Public Property Valor As String
            End Class

        End Class
    End Class
End Namespace