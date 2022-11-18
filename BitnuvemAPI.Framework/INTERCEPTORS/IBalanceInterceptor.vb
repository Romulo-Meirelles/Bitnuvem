
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
    Public Interface IInterceptor
    End Interface
    Public Interface IBalanceInterceptor
        Inherits IInterceptor

#Region "API TRADE"
        Function CheckBalanceRequestAsync() As Task(Of InterceptorResult)
        Function AccountBankListRequestAsync() As Task(Of InterceptorResult)
        Function WithdrawRequestAsync() As Task(Of InterceptorResult)
        Function SendRequestAsync() As Task(Of InterceptorResult)
        Function Order_GetRequestAsync() As Task(Of InterceptorResult)
        Function Order_ListRequestAsync() As Task(Of InterceptorResult)
        Function Order_NewRequestAsync() As Task(Of InterceptorResult)
        Function Order_CancelRequestAsync() As Task(Of InterceptorResult)
        Function Order_Cancel_AllRequestAsync() As Task(Of InterceptorResult)
#End Region

#Region "API"
        Function Ticker_RequestAsync() As Task(Of InterceptorResult)
        Function OrderBook_RequestAsync() As Task(Of InterceptorResult)
        Function Trades_RequestAsync() As Task(Of InterceptorResult)
        Function Fee_RequestAsync() As Task(Of InterceptorResult)
#End Region
    End Interface
End Namespace
