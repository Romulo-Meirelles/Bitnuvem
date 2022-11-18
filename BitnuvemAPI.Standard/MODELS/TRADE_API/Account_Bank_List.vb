Imports Newtonsoft.Json
Namespace Bitnuvem
    <JsonObject>
    Public Class Account_Bank_List
        Inherits BitnuvemResponse
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



        <JsonProperty("root")>
        Public Property Result As List(Of Results)

        Class Results
            <JsonProperty("id")>
            Public Property id As Integer

            <JsonProperty("cpf_cnpj")>
            Public Property cpf_cnpj As String

            <JsonProperty("bank")>
            Public Property bank As String

            <JsonProperty("agency")>
            Public Property agency As String

            <JsonProperty("agency_digit")>
            Public Property agency_digit As String

            <JsonProperty("account")>
            Public Property account As String

            <JsonProperty("account_digit")>
            Public Property account_digit As String

            <JsonProperty("account_type")>
            Public Property account_type As String

            <JsonProperty("account_name")>
            Public Property account_name As String

            <JsonProperty("operation")>
            Public Property operation As String
        End Class

        Public Overrides Function ToString() As String
            Dim Response As String = String.Empty

            For i = 0 To Result.Count - 1
                Response += "Id: " & Result(i).id & vbCrLf
                Response += "CPF/CNPJ: " & Result(i).cpf_cnpj & vbCrLf
                Response += "Banco: " & Result(i).bank & vbCrLf
                Response += "Agência: " & Result(i).agency & vbCrLf
                Response += "Dígito Agencia: " & Result(i).agency_digit & vbCrLf
                Response += "Conta: " & Result(i).account & vbCrLf
                Response += "Dígito Conta: " & Result(i).account_digit & vbCrLf
                Response += "Tipo Conta " & Result(i).account_type & vbCrLf
                Response += "Titular: " & Result(i).account_name & vbCrLf
                Response += "Operação: " & Result(i).operation & vbCrLf & vbCrLf
            Next
            Return Response
        End Function
    End Class
End Namespace
