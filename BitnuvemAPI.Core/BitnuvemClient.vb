Imports System.Net.Http

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
    Public Class BitnuvemClient : Implements IBitnuvemClient

        Private ReadOnly _Requester As IRequester
        Public Sub New(ByVal Requester As IRequester)
            _Requester = Requester
        End Sub

        Public Shared Function Create(ByVal Config As ApiConfig, ByVal Optional Client As HttpClient = Nothing) As BitnuvemClient
            Dim Requester = HttpClientRequester.Create(Config, Client)
            Return New BitnuvemClient(Requester)
        End Function

#Region "API TRADE"
        Public Async Function Balance() As Task(Of BalanceResponse) Implements IBitnuvemClient.Balance
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.CheckBalanceRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim RequestBody As String = http_build_query({"timestamp"}, {Time}) '"timestamp=" & Time
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of BalanceResponse)("balance", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function AccountBankList() As Task(Of Account_Bank_List) Implements IBitnuvemClient.AccountBankList
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.AccountBankListRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim RequestBody As String = http_build_query({"timestamp"}, {Time}) '"timestamp=" & Time
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Account_Bank_List)("account_bank_list", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Withdraw(Valor As String, BancoID As String) As Task(Of Withdraw) Implements IBitnuvemClient.Withdraw
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.WithdrawRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim RequestBody As String = http_build_query({"timestamp", "value", "bank_id"}, {Time, Valor, BancoID}) '"timestamp=" & Time & "?value=" & Valor & "?bank_id=" & BancoID
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Withdraw)("withdraw", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Send(BitcoinValor As String, CarteiraEndereco As String, Optional [Type] As Taxa = Taxa.Baixo) As Task(Of Send) Implements IBitnuvemClient.Send
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.SendRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim Taxacao As String = String.Empty

            Select Case [Type]
                Case BitnuvemClient.Taxa.Prioritario
                    Taxacao = "high"
                Case BitnuvemClient.Taxa.Regular
                    Taxacao = "regular"
                Case BitnuvemClient.Taxa.Baixo
                    Taxacao = "low"
            End Select

            Dim RequestBody As String = http_build_query({"timestamp", "amount", "address", "type"}, {Time, BitcoinValor, CarteiraEndereco, Taxacao}) '"timestamp=" & Time & "?amount=" & BitcoinValor & "?address=" & CarteiraEndereco & "?type=" & Taxacao
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Send)("send", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_Get(Order_Id As String) As Task(Of Order_Get) Implements IBitnuvemClient.Order_Get
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_GetRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString

            Dim RequestBody As String = http_build_query({"timestamp", "order_id"}, {Time, Order_Id})
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_Get)("order_get", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_List(Optional Status As OrderList = OrderList.Todas) As Task(Of Order_List) Implements IBitnuvemClient.Order_List
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_ListRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString

            Dim Stu As String = String.Empty
            Select Case Status
                Case BitnuvemClient.OrderList.Todas
                    Stu = "all"
                Case BitnuvemClient.OrderList.Ativas
                    Stu = "active"
                Case BitnuvemClient.OrderList.Concluidas
                    Stu = "completed"
                Case BitnuvemClient.OrderList.Canceladas
                    Stu = "canceled"
            End Select

            Dim RequestBody As String = http_build_query({"timestamp", "status"}, {Time, Stu})
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_List)("order_list", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_New_Limite(Tipo As Order, ValorBitcoin As String, Preco_Unitario As String, Optional Preco_Stop As String = "", Optional Preco_OCO As String = "") As Task(Of Order_New_Limite) Implements IBitnuvemClient.Order_New_Limite
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_NewRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim Tpo As String = String.Empty
            Select Case Tipo
                Case BitnuvemClient.OrderType.Compra
                    Tpo = "buy"
                Case BitnuvemClient.OrderType.Venda
                    Tpo = "sell"
            End Select
            Dim RequestBody As String = http_build_query({"timestamp", "mode", "type", "amount", "price", "price_stop", "price_oco"}, {Time, "limit", Tpo, ValorBitcoin, Preco_Unitario, Preco_Stop, Preco_OCO}) '"timestamp=" & Time & "?mode=Limit" & "?type=" & Tpo & "?amount=" & ValorBitcoin & "?price=" & Preco_Unitario & "?price_stop=" & Preco_Stop & "?price_oco=" & Preco_OCO
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_New_Limite)("order_new", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_New_Mercado(Tipo As OrderType, ValorBitcoin As String, Total As String, Optional Preco_Stop As String = "") As Task(Of Order_New_Limite) Implements IBitnuvemClient.Order_New_Mercado
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_NewRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim Tpo As String = String.Empty
            Select Case Tipo
                Case BitnuvemClient.OrderType.Compra
                    Tpo = "buy"
                Case BitnuvemClient.OrderType.Venda
                    Tpo = "sell"
            End Select
            Dim RequestBody As String = http_build_query({"timestamp", "mode", "type", "amount", "total", "price_stop"}, {Time, "market", Tpo, ValorBitcoin, Total, Preco_Stop}) '"timestamp=" & Time & "?mode=market" & "?type=" & tpo & "?amount=" & ValorBitcoin & "?total=" & Total & "?price_stop=" & Preco_Stop
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_New_Limite)("order_new", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_New_Escalonado(Tipo As OrderType, ValorBitcoin As String, Total As String, TypeScale As String, NumerodeOrdens As String, PrecoMin As String, PrecoMax As String) As Task(Of Order_New_Limite) Implements IBitnuvemClient.Order_New_Escalonado
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_NewRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim Tpo As String = String.Empty
            Select Case Tipo
                Case BitnuvemClient.OrderType.Compra
                    Tpo = "buy"
                Case BitnuvemClient.OrderType.Venda
                    Tpo = "sell"
            End Select
            Dim RequestBody As String = http_build_query({"timestamp", "mode", "type", "amount", "total", "type_scale", "number_orders", "price_min", "price_max"}, {Time, "scale", Tpo, ValorBitcoin, Total, TypeScale, NumerodeOrdens, PrecoMin, PrecoMax}) '"timestamp=" & Time & "?mode=scale" & "?type=" & Type & "?amount=" & ValorBitcoin & "?total=" & Total & "?type_scale=" & TypeScale & "?number_orders=" & NumerodeOrdens & "?price_min=" & PrecoMin & "?price_max=" & PrecoMax
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_New_Limite)("order_new", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_Cancel(Order_Id As String) As Task(Of Order_Cancel) Implements IBitnuvemClient.Order_Cancel
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_CancelRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString
            Dim RequestBody As String = http_build_query({"timestamp", "order_id"}, {Time, Order_Id}) '"timestamp=" & Time & "?order_id=" & Order_Id
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_Cancel)("order_cancel", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Async Function Order_Cancel_All(Tipo As OrderType) As Task(Of Order_Cancel) Implements IBitnuvemClient.Order_Cancel_All
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Order_Cancel_AllRequestAsync())
            Dim HMAC As New HMAC256
            Dim Time As String = TimeToUnix(DateTime.UtcNow).ToString

            Dim Tpo As String = String.Empty
            Select Case Tipo
                Case BitnuvemClient.OrderType.Compra
                    Tpo = "buy"
                Case BitnuvemClient.OrderType.Venda
                    Tpo = "sell"
                Case BitnuvemClient.OrderType.Todas
                    Tpo = "all"
            End Select

            Dim RequestBody As String = http_build_query({"timestamp"}, {Time}) '"timestamp=" & Time & "?type=" & Tpo
            Dim Signature = HMAC.Create_HMACSHA256_Sign(RequestBody, _Requester.Configuration.SecretKey)
            Return Await _Requester.Post(Of Order_Cancel)("order_cancel/all", New Dictionary(Of String, String) From {{"api_key", _Requester.Configuration.ApiKey}, {"request_body", RequestBody}, {"signature", Signature}}).ConfigureAwait(False)
        End Function

        Public Enum Taxa
            Prioritario = 1
            Regular = 2
            Baixo = 3
        End Enum
        Public Enum OrderList
            Todas = 1
            Ativas = 2
            Concluidas = 3
            Canceladas = 4
        End Enum

        Public Enum OrderType
            Compra = 1
            Venda = 2
            Todas = 3
        End Enum

        Public Enum Order
            Compra = 1
            Venda = 2
        End Enum
#End Region

#Region "API"
        Public Async Function Ticker() As Task(Of Ticker) Implements IBitnuvemClient.Tick
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Ticker_RequestAsync())
            Return Await _Requester.Post(Of Ticker)("ticker", New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function

        Public Async Function OrderBook() As Task(Of OrderBook) Implements IBitnuvemClient.OrderBook
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.OrderBook_RequestAsync())
            Return Await _Requester.Post(Of OrderBook)("orderbook", New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function

        Public Async Function Trades(From As Date, Optional [To] As Date = Nothing) As Task(Of Trades) Implements IBitnuvemClient.Trades
            Dim F = TimeToUnix(From)
            Dim T = String.Empty

            If [To] = Date.Parse("#1/1/0001 12:00:00 AM#") Then
                T = ""
            Else
                T = TimeToUnix([To])
            End If

            Dim RequestBody As String = http_build_query({"from", "to"}, {F, T})

            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Trades_RequestAsync())
            Return Await _Requester.Post(Of Trades)("trades?" & RequestBody, New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function
        Public Async Function Cotacao() As Task(Of Cotacao) Implements IBitnuvemClient.Cotacao
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.OrderBook_RequestAsync())
            Return Await _Requester.Post(Of Cotacao)("cotacao", New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function

        Public Async Function AdvanceTrade() As Task(Of TradeAdvanced) Implements IBitnuvemClient.AdvanceTrade
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.OrderBook_RequestAsync())
            Return Await _Requester.Post(Of TradeAdvanced)("trade/advance", New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function
        Public Async Function Fee() As Task(Of Fee) Implements IBitnuvemClient.Fee
            Await _Requester.Configuration.SendInterceptors.ThrowInterceptorErrorsAsync(Function(i) i.Fee_RequestAsync())
            Return Await _Requester.Post(Of Fee)("fee", New Dictionary(Of String, String) From {}).ConfigureAwait(False)
        End Function
#End Region

#Region "Tools"
        Friend Function http_build_query(ByVal ParameterNames() As String, ByVal ParameterValues() As String) As String
            Dim sRet As String = ""
            If ParameterNames.Length <> ParameterValues.Length Then Throw New System.Exception("The parameter arrays do not match.")
            For i As Integer = 0 To ParameterNames.Length - 1
                sRet = String.Concat(sRet, IIf(sRet = "", "", "&"), ParameterNames(i), "=", ParameterValues(i))
            Next
            Return sRet
        End Function
        Public Function TimeToUnix(ByVal dteDate As Date) As String
            If dteDate.IsDaylightSavingTime = True Then
                dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
            End If
            TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
        End Function

        Public Function UnixToTime(ByVal strUnixTime As String) As Date
            UnixToTime = DateAdd(DateInterval.Second, Val(strUnixTime), #1/1/1970#)
            If UnixToTime.IsDaylightSavingTime = True Then
                UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
            End If
        End Function
#End Region
        Public Sub Dispose() Implements IBitnuvemClient.Dispose
            Dim Disposable As IDisposable = Nothing

            If [Implements].Assign(Disposable, TryCast(_Requester, IDisposable)) IsNot Nothing Then
                Disposable.Dispose()
            End If
        End Sub
        Private Class [Implements]
            Shared Function Assign(Of T)(ByRef Target As T, Value As T) As T
                Target = Value
                Return Value
            End Function
        End Class

    End Class
End Namespace
