Imports BitnuvemAPI.Bitnuvem

Module Program

    Private ReadOnly APIKEY = "4a65sd4f6a5sd4f8e6sd1f6asd54f6a5sd"
    Private ReadOnly SECRETKEY = "6d54fqweADg65d6f5a4654asdASDq6548"
    Sub Main(args As String())
        Call Start()
        Console.ReadLine()
    End Sub

    Private Async Sub Start()
        Using Client = BitnuvemClient.Create(New ApiConfig With {.ApiKey = APIKEY, .SecretKey = SECRETKEY})
            Try
                '-----------------------------------------  API de dados ----------------------------------------

                Dim B = Await Client.Trades(Date.Now.AddDays(-2), Date.Now)
                Console.WriteLine(B.ToString)
                Console.WriteLine()

                Dim Ticker = Await Client.Ticker
                Console.WriteLine(Ticker.ToString)
                Console.WriteLine()

                Dim Orderbook = Await Client.OrderBook
                Console.WriteLine(Orderbook.ToString)
                Console.WriteLine()

                Dim Fee = Await Client.Fee
                Console.WriteLine(Fee.ToString)
                Console.WriteLine()

                Dim Trades = Await Client.Trades(Date.Now.AddDays(-1), Date.Now)
                Console.WriteLine(Trades.ToString)

                Dim Cotacao = Await Client.Cotacao
                Console.WriteLine(Cotacao.ToString)
                Console.WriteLine()

                Dim AdvanceTrade = Await Client.AdvanceTrade

                Console.WriteLine("Data: " & AdvanceTrade.Data.DataBook & vbCrLf)
                Console.WriteLine("Spread Valor: " & AdvanceTrade.Data.Livro_Ofertas.Informacoes.Spread.Valor & vbCrLf)
                Console.WriteLine("Spread Porcentagem: " & AdvanceTrade.Data.Livro_Ofertas.Informacoes.Spread.Porcentagem & vbCrLf)
                Console.WriteLine("Mínimo: " & AdvanceTrade.Data.Livro_Ofertas.Informacoes.Minimo & vbCrLf)
                Console.WriteLine("Máximo: " & AdvanceTrade.Data.Livro_Ofertas.Informacoes.Maximo & vbCrLf)

                Console.WriteLine("----- Ordens Compra -----" & vbCrLf)
                For i = 0 To 10 - 1
                    Console.WriteLine("Data: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Data & vbCrLf &
                                      "Ordem Nova: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Ordem_Nova & vbCrLf &
                                      "Quantidade: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Quantidade & vbCrLf &
                                      "Valor BitCoin: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Valor_BTC & vbCrLf &
                                      "Total: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Total & vbCrLf &
                                      "Relevância: " & AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens(i).Relevancia & vbCrLf & vbCrLf)
                Next

                Console.WriteLine("----- Ordens Vendas -----" & vbCrLf)
                For i = 0 To 10 - 1
                    Console.WriteLine("Data: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Data & vbCrLf &
                                      "Ordem Nova: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Ordem_Nova & vbCrLf &
                                      "Quantidade: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Quantidade & vbCrLf &
                                      "Valor BitCoin: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Valor_BTC & vbCrLf &
                                      "Total: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Total & vbCrLf &
                                      "Relevância: " & AdvanceTrade.Data.Livro_Ofertas.Vendas.Ordens(i).Relevancia & vbCrLf & vbCrLf)
                Next

                Console.WriteLine("----- Ultimas -----" & vbCrLf)
                For i = 0 To 10 - 1
                    Console.WriteLine("Tipo: " & AdvanceTrade.Data.Ultimas(i).Tipo & vbCrLf &
                                      "Data: " & AdvanceTrade.Data.Ultimas(i).Data & vbCrLf &
                                      "Quantidade: " & AdvanceTrade.Data.Ultimas(i).Quantidade & vbCrLf &
                                      "Preço: " & AdvanceTrade.Data.Ultimas(i).Preco & vbCrLf &
                                      "Valor: " & AdvanceTrade.Data.Ultimas(i).Valor & vbCrLf & vbCrLf & vbCrLf)
                Next


                Console.WriteLine(AdvanceTrade.Data.Livro_Ofertas.Compras.Ordens)
                Console.WriteLine()


                '--------------------------------------- API de Negociação ----------------------------------

                Dim Balance = Await Client.Balance
                Console.WriteLine(Balance.ToString)
                Console.WriteLine()

                Dim BankList = Await Client.AccountBankList
                Console.WriteLine(BankList.ToString)
                Console.WriteLine()

                Dim WithDraw = Await Client.Withdraw("150.50", "2541326")
                Console.WriteLine(WithDraw.ToString)
                Console.WriteLine()

                Dim Send = Await Client.Send("0.00000200", "1NeqX3foY5RpVrgeeKCnbdaeC6xJQ5EyMg", BitnuvemClient.Taxa.Baixo)
                Console.WriteLine(Send.ToString)
                Console.WriteLine()

                Dim GetOrder = Await Client.Order_Get("55478956")
                Console.WriteLine(GetOrder.ToString)
                Console.WriteLine()

                Dim GetOrderList = Await Client.Order_List(BitnuvemClient.OrderList.Ativas)
                Console.WriteLine(GetOrderList.ToString)
                Console.WriteLine()

                Dim CancelOrder = Await Client.Order_Cancel("55478956")
                Console.WriteLine(CancelOrder.ToString)
                Console.WriteLine()

                Dim CancelAllOrder = Await Client.Order_Cancel_All(BitnuvemClient.OrderType.Venda)
                Console.WriteLine(CancelAllOrder.ToString)
                Console.WriteLine()

                Dim VendaLimite = Await Client.Order_New_Limite(BitnuvemClient.Order.Venda, "0.00410880", "95494.72")
                Console.WriteLine(VendaLimite.ToString)
                Console.WriteLine()

                Dim ComprarLimite = Await Client.Order_New_Limite(BitnuvemClient.Order.Compra, "0.00410880", "95494.72")
                Console.WriteLine(ComprarLimite.ToString)
                Console.WriteLine()

                Dim VendaMercado = Await Client.Order_New_Mercado(BitnuvemClient.Order.Venda, "0.00410880", "")
                Console.WriteLine(VendaMercado.ToString)
                Console.WriteLine()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub
End Module
