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
    Public Class Fee
        Inherits BitnuvemResponse


        <JsonProperty("low")>
        Public Property Baixo As String

        <JsonProperty("regular")>
        Public Property Regular As String

        <JsonProperty("priority")>
        Public Property Alta As String



        Public Overrides Function ToString() As String
            Return "Baixo: " & Baixo & vbCrLf &
                   "Regular: " & Regular & vbCrLf &
                   "Alta: " & Alta & vbCrLf
        End Function
    End Class
End Namespace