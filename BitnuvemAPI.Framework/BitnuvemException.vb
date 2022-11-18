Imports System.Runtime.Serialization

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
    Public Class BitnuvemException
        Inherits Exception
        Public ReadOnly Property StatusCode As Integer
        Public Sub New()
        End Sub
        Public Sub New(ByVal statusCode As Integer)
            Me.StatusCode = statusCode
        End Sub
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(ByVal message As String, ByVal statusCode As Integer)
            MyBase.New(message)
            Me.StatusCode = statusCode
        End Sub
        Public Sub New(ByVal message As String, ByVal innerException As Exception)
            MyBase.New(message, innerException)
            Me.StatusCode = StatusCode
        End Sub
        Public Sub New(ByVal message As String, ByVal statusCode As Integer, ByVal innerException As Exception)
            MyBase.New(message, innerException)
            Me.StatusCode = statusCode
        End Sub
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        Public Function HasError(ByVal [error] As BitnuvemError) As Boolean
            Return StatusCode = [error]
        End Function
        Public Function HasError(ByVal [error] As BitnuvemError, ParamArray errors As BitnuvemError()) As Boolean
            Return errors.Concat({[error]}).Any(Function(e) StatusCode = e)
        End Function
    End Class

    Public Enum BitnuvemError

        Algo_inesperado_aconteceu = 106
        Chave_privada_invalida = 130
        E_necessario_ativar_a_Autenticação_em_2_passos = 131
        Essa_chave_privada_ainda_nao_foi_confirmada_por_e_mail = 132
        Time_Stamp_incorreto = 133
        Requisicao_invalida = 134
        E_necessario_ter_cadastro_completo_para_usar_a_API_de_Negociacao = 135
        Saldo_em_Bitcoin_insuficiente = 254
        Voce_precisa_transferir_no_minimo_0_00001000_BTC = 255
        O_endereco_da_carteira_destino_e_invalido = 256
        Você_nao_possui_saldo_Bitcoin_suficiente = 259
        Você_nao_possui_saldo_em_reais_suficiente = 260
        Conta_bancaria_nao_encontrada = 261
        Você_precisa_sacar_no_minimo_RS_10_00 = 264
        Os_valores_precisam_ser_maiores_que_0 = 267
        Saldo_em_Bitcoin_insuficiente_0 = 268
        Saldo_em_reais_insuficiente = 270
        Ordem_cancelada = 271
        Ordem_stop_preco_adicionada = 290
        O_valor_stop_de_venda_no_modo_OCO_deve_ser_menor_que_o_valor_de_venda_padrao = 291
        O_valor_stop_de_compra_no_modo_OCO_deve_ser_maior_que_o_valor_de_compra_padrao = 292
        Nao_e_possivel_lancar_ordens_com_valor_total_abaixo_de_RS_10_00__Tente_novamente_com_valores_maiores = 303
        Nao_e_possivel_lancar_ordens_com_valor_total_acima_de_RS_50_000_00__Tente_novamente_com_valores_menores = 305
        Nao_e_possivel_lancar_ordens_STOP_com_valor_de_compra_abaixo_da_melhor_oferta_de_compra_atual_e_ou_ultimo_valor_negociado = 306
        Nao_e_possivel_lancar_ordens_STOP_com_valor_de_venda_acima_da_melhor_oferta_de_venda_atual_e_ou_ultimo_valor_negociado = 307
        Aguarde_seu_depósito_de_bitcoin_ter_3_confirmacoes_para_prosseguir_com_esta_acao_Acompanhe_aqui = 313
        O_preco_unitario_minimo_deve_ser_acima_que_a_melhor_oferta_de_compra = 315
        O_preco_unitario_maximo_deve_ser_abaixo_que_a_melhor_oferta_de_venda = 316
        O_preco_unitario_maximo_deve_ser_maior_que_o_preco_unitario_minimo = 317
        Sao_permitidos_criar_numeros_de_ordem_entre_2_e_30 = 318
        Sua_chave_privada_nao_tem_acesso_à_essa_funcao = 331
        Esse_valor_excede_o_limite_de_RS_2_000_00_permitidos_para_usuario_sem_cadastro_completo__Conclua_seu_cadastro_clicando_aqui = 339
        Esse_valor_excede_o_limite_de_0_04000000_BTC_permitidos_para_usuario_sem_cadastro_completo__Conclua_seu_cadastro_clicando_aqui = 340
        É_possivel_realizar_somente_1_requisicao_por_segundo = 382
        Você_realizou_mais_de_60_requisicoes_por_minuto__Aguarde_alguns_instante_para_voltar_usar_a_API_de_Negociacao = 383
        Este_endereco_nao_e_o_mesmo_configurado_da_chave_da_API_de_Negociacoes = 440
    End Enum
End Namespace
