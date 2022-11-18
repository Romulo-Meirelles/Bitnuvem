
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
    Public Interface IBitnuvemClient
        Inherits IDisposable

#Region "API TRADE"
        Function Balance() As Task(Of BalanceResponse)
        Function AccountBankList() As Task(Of Account_Bank_List)
        Function Withdraw(Valor As String, BancoID As String) As Task(Of Withdraw)
        Function Send(BitcoinValor As String, CarteiraEndereco As String, Optional [Type] As BitnuvemClient.Taxa = BitnuvemClient.Taxa.Baixo) As Task(Of Send)
        Function Order_Get(Order_Id As String) As Task(Of Order_Get)
        Function Order_List(Optional Status As BitnuvemClient.OrderList = BitnuvemClient.OrderList.Todas) As Task(Of Order_List)
        Function Order_New_Limite(Tipo As BitnuvemClient.Order, ValorBitcoin As String, Preco As String, Optional Preco_Stop As String = "", Optional Preco_OCO As String = "") As Task(Of Order_New_Limite)
        Function Order_New_Mercado(Tipo As BitnuvemClient.OrderType, ValorBitcoin As String, Total As String, Optional Preco_Stop As String = "") As Task(Of Order_New_Limite)
        Function Order_New_Escalonado(Tipo As BitnuvemClient.OrderType, ValorBitcoin As String, Total As String, TypeScale As String, NumerodeOrdens As String, PrecoMin As String, PrecoMax As String) As Task(Of Order_New_Limite)
        Function Order_Cancel(Order_ID As String) As Task(Of Order_Cancel)
        Function Order_Cancel_All(Tipo As BitnuvemClient.OrderType) As Task(Of Order_Cancel)

#End Region


#Region "API"
        Function Tick() As Task(Of Ticker)
        Function OrderBook() As Task(Of OrderBook)
        Function Trades(From As Date, Optional [To] As Date = Nothing) As Task(Of Trades)
        Function Fee() As Task(Of Fee)
        Function Cotacao() As Task(Of Cotacao)
        Function AdvanceTrade() As Task(Of TradeAdvanced)

#End Region
    End Interface
End Namespace
