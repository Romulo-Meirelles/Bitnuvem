Imports BitnuvemAPI.Bitnuvem
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Serialization

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
    Public MustInherit Class RequesterBase
        Implements IRequester
        Public Sub New(ByVal configuration As ApiConfig)
            Me.Configuration = configuration
            configuration.Check()
        End Sub

        Private Shared ReadOnly Settings As JsonSerializerSettings = New JsonSerializerSettings With {
                .ContractResolver = New DefaultContractResolver With {
                .NamingStrategy = New SnakeCaseNamingStrategy()
                        }
                    }
        Protected Overridable Function Deserialize(Of T)(json As String) As T
            Try
                Return JsonConvert.DeserializeObject(Of T)(json, Settings)

            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Protected Overridable Function Serialize(ByVal obj As Object) As String
            Return JsonConvert.SerializeObject(obj, Settings)
        End Function

        Protected Iterator Function CreateParameterPairs(ByVal Optional source As IEnumerable(Of KeyValuePair(Of String, String)) = Nothing) As IEnumerable(Of KeyValuePair(Of String, String))
            Yield New KeyValuePair(Of String, String)("api_key", Configuration.ApiKey)
            If source Is Nothing Then Return
            For Each item In source
                Yield item
            Next
        End Function
        Public ReadOnly Property Configuration As ApiConfig Implements IRequester.Configuration

        Public Shared Sub HandleError(ByVal statusCode As Integer, ByVal Message As String, ByVal Optional innerException As Exception = Nothing, ByVal Optional noThrow As Boolean = False)
            If noThrow Then Return
            If statusCode >= 106 AndAlso statusCode <= 135 Then
                Throw New BitnuvemException(ErrorModels(statusCode), statusCode, innerException)
            ElseIf statusCode >= 254 AndAlso statusCode <= 440 Then
                Throw New BitnuvemException(ErrorModels(statusCode), statusCode, innerException)
            Else
                Return ' Success!
            End If
        End Sub

        Private Shared Function ErrorModels(ByVal ErrorNumber As Integer) As String

            If ErrorNumber = 200 Then
                Return "Solicitação realizada com sucesso"
            End If

            If ErrorNumber = 106 Then
                Return "Algo inesperado aconteceu, tente novamente ou contate o suporte. [06]"
            ElseIf ErrorNumber = 130 Then
                Return "Chave privada inválida."
            ElseIf ErrorNumber = 131 Then
                Return "É necessário ativar a Autenticação em 2 passos para usar a API de Negocionações."
            ElseIf ErrorNumber = 132 Then
                Return "Essa chave privada ainda não foi confirmada por e-mail. Acesse sua caixa postal ou reenvie a confirmação acessando sua conta pela plataforma"
            ElseIf ErrorNumber = 133 Then
                Return "Time Stamp incorreto."
            ElseIf ErrorNumber = 134 Then
                Return "Requisição inválida."
            ElseIf ErrorNumber = 135 Then
                Return "É necessário ter cadastro completo para usar a API de Negociação"
            ElseIf ErrorNumber = 214 Then
                Return "Ação completada com sucesso!"
            ElseIf ErrorNumber = 254 Then
                Return "Saldo em Bitcoin insuficiente."
            ElseIf ErrorNumber = 255 Then
                Return "Você precisa transferir no mínimo 0.00001000 BTC."
            ElseIf ErrorNumber = 256 Then
                Return "O endereço da carteira destino é inválido."
            ElseIf ErrorNumber = 259 Then
                Return "Você não possui saldo Bitcoin suficiente."
            ElseIf ErrorNumber = 260 Then
                Return "Você não possui saldo em Reais suficiente."
            ElseIf ErrorNumber = 261 Then
                Return "Conta bancária não encontrada."
            ElseIf ErrorNumber = 264 Then
                Return "Você precisa sacar no mínimo R$ 10,00."
            ElseIf ErrorNumber = 267 Then
                Return "Os valores precisam ser maiores que 0."
            ElseIf ErrorNumber = 268 Then
                Return "Saldo em Bitcoin insuficiente."
            ElseIf ErrorNumber = 270 Then
                Return "Saldo em reais insuficiente."
            ElseIf ErrorNumber = 271 Then
                Return "Ordem cancelada."
            ElseIf ErrorNumber = 290 Then
                Return "Ordem stop-preco adicionada."
            ElseIf ErrorNumber = 291 Then
                Return "O valor stop de venda no modo OCO deve ser menor que o valor de venda padrão."
            ElseIf ErrorNumber = 292 Then
                Return "O valor stop de compra no modo OCO deve ser maior que o valor de compra padrão."
            ElseIf ErrorNumber = 303 Then
                Return "Não é possível lançar ordens com valor total abaixo de R$ 10,00. Tente novamente com valores maiores."
            ElseIf ErrorNumber = 305 Then
                Return "Não é possível lançar ordens com valor total acima de R$ 50.000,00. Tente novamente com valores menores."
            ElseIf ErrorNumber = 306 Then
                Return "Não é possível lançar ordens STOP com valor de compra abaixo da melhor oferta de compra atual e/ou último valor negociado."
            ElseIf ErrorNumber = 307 Then
                Return "Não é possível lançar ordens STOP com valor de venda acima da melhor oferta de venda atual e/ou último valor negociado."
            ElseIf ErrorNumber = 313 Then
                Return "Aguarde seu depósito de bitcoin ter 3 confirmações para prosseguir com esta ação."
            ElseIf ErrorNumber = 314 Then
                Return "Todas suas ordens foram canceladas com sucesso!"
            ElseIf ErrorNumber = 315 Then
                Return "O preço unitário mínimo deve ser acima que a melhor oferta de compra."
            ElseIf ErrorNumber = 316 Then
                Return "O preço unitário máximo deve ser abaixo que a melhor oferta de venda."
            ElseIf ErrorNumber = 317 Then
                Return "O preço unitário máximo deve ser maior que o preço unitário mínimo."
            ElseIf ErrorNumber = 318 Then
                Return "São permitidos criar numeros de ordem entre 2 e 30."
            ElseIf ErrorNumber = 331 Then
                Return "Sua chave privada não tem acesso à essa função."
            ElseIf ErrorNumber = 339 Then
                Return "Esse valor excede o limite de R$ 2.000,00 permitidos para usuário sem cadastro completo. Conclua seu cadastro."
            ElseIf ErrorNumber = 340 Then
                Return "Esse valor excede o limite de 0.04000000 BTC permitidos para usuário sem cadastro completo. Conclua seu cadastro."
            ElseIf ErrorNumber = 382 Then
                Return "É possível realizar somente 1 requisição por segundo."
            ElseIf ErrorNumber = 383 Then
                Return "Você realizou mais de 60 requisições por minuto. Aguarde alguns instante para voltar usar a API de Negociação."
            ElseIf ErrorNumber = 440 Then
                Return "Este endereço não é o mesmo configurado da chave da API de Negociações."
            End If
            Return "Unknown Error."
        End Function
        Public MustOverride Function Post(Of T As BitnuvemResponse)(ByVal resource As String, ByVal Optional parameters As Dictionary(Of String, String) = Nothing, ByVal Optional noThrow As Boolean = False) As Task(Of T) Implements IRequester.Post
    End Class
End Namespace
