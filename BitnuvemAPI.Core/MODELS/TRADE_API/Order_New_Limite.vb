﻿Imports Newtonsoft.Json

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
    Public Class Order_New_Limite
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
        End Class

        Public Overrides Function ToString() As String
                On Error Resume Next
            Dim Response As String = String.Empty
            For i = 0 To Result.Count - 1
                Response += "Id: " & Result(i).Id & vbCrLf
                Response += "Criado: " & Result(i).Criado & vbCrLf
                Response += "Modo: " & Result(i).Modo & vbCrLf
                Response += "Tipo: " & Result(i).Tipo & vbCrLf
                Response += "Status: " & Result(i).Status & vbCrLf
                Response += "Quantidade: " & Result(i).Quantidade & vbCrLf
                Response += "Preço: " & Result(i).Preco & vbCrLf
                Response += vbCrLf
            Next

            Return Response
            End Function
        End Class
End Namespace