# ![Logo](https://raw.githubusercontent.com/Romulo-Meirelles/Bitnuvem/main/Pictures/Bitnuvem_logo.png) 
   BitnuvemAPI - (.NetFramework | .NetStandard | .NetCore)

[![NuGet version (BitnuvemAPI)](https://img.shields.io/nuget/v/BitnuvemAPI.svg?style=flat-square)](https://www.nuget.org/packages/BitnuvemAPI/)

BITNUVEM API NÃO OFICIAL (UNOFFICIAL).

API para voce fazer consultas, saques, pagamentos trades na plataforma Bitnuvem.

- Características
- Faça pagamentos.
- Veja os Book de ofertas.
- Veja seu balanço.
- Verifique suas ordens.
- Encerre ordens ativas.
- Abra ordens.
- Veja o histórico de suas transações.
- Faça saques.
- Gerencie seus ativos e dinheiro.
- Fácil de usar.

#DIVIRTA-SE!

##  ALGUNS EXEMPLOS DE COMO USAR.

## Visual Basic

```vb
Using Client = BitnuvemClient.Create(New ApiConfig With {.ApiKey = "25g7i3e6d17835bdf136d8ab2efv94er", .SecretKey = "8ur15dXbawTu9nUzyYpfFBaXiq3iR1ff"})
Try
 'PEGA O SEU BALANÇO.
 Dim Balance = Await Client.Balance
 Console.WriteLine(Balance.ToString)
 Console.WriteLine()
 
 'CRIA UMA NOVA ORDEM DE VENDA OU COMPRA LIMITE.
 Dim VendaLimite = Await Client.Order_New_Limite(BitnuvemClient.Order.Venda, "0.00410880", "95494.72")
 Console.WriteLine(VendaLimite.ToString)
 Console.WriteLine()
 
 'LISTA TODAS AS ORDEM (ATIVAS, CANCELADAS OU PENDENTES).
 Dim GetOrderList = Await Client.Order_List(BitnuvemClient.OrderList.Ativas)
 Console.WriteLine(GetOrderList.ToString)
 Console.WriteLine()
             
 'CANCELA UMA ORDEM DE COMPRA OU VENDA COM IDENTIFICAÇÃO           
 Dim CancelOrder = Await Client.Order_Cancel("48783624")
 Console.WriteLine(CancelOrder.ToString)
 Console.WriteLine()
 
 'CANCELA TODAS AS ORDENS QUE ESTIVEREM ABERTAS.
 Dim CancelAllOrder = Await Client.Order_Cancel_All(BitnuvemClient.OrderType.Venda)
 Console.WriteLine(CancelAllOrder.ToString)
 Console.WriteLine()
 
Catch ex As Exception
Console.WriteLine(ex.Message)
End Try
```

## C# CSharp

```csharp
{
    using (var Client = BitnuvemClient.Create(new ApiConfig() { ApiKey = "25g7i3e6d17835bdf136d8ab2efv94er", SecretKey = "8ur15dXbawTu9nUzyYpfFBaXiq3iR1ff" }))
    {
        try
        {
            // PEGA O SEU BALANÇO.
            var Balance = Await Client.Balance;
            Console.WriteLine(Balance.ToString);
            Console.WriteLine();

            // CRIA UMA NOVA ORDEM DE VENDA OU COMPRA LIMITE.
            var VendaLimite = Await Client.Order_New_Limite(BitnuvemClient.Order.Venda, "0.00410880", "95494.72");
            Console.WriteLine(VendaLimite.ToString);
            Console.WriteLine();

            // LISTA TODAS AS ORDEM (ATIVAS, CANCELADAS OU PENDENTES).
            var GetOrderList = Await Client.Order_List(BitnuvemClient.OrderList.Ativas);
            Console.WriteLine(GetOrderList.ToString);
            Console.WriteLine();

            // CANCELA UMA ORDEM DE COMPRA OU VENDA COM IDENTIFICAÇÃO           
            var CancelOrder = Await Client.Order_Cancel("48783624");
            Console.WriteLine(CancelOrder.ToString);
            Console.WriteLine();

            // CANCELA TODAS AS ORDENS QUE ESTIVEREM ABERTAS.
            var CancelAllOrder = Await Client.Order_Cancel_All(BitnuvemClient.OrderType.Venda);
            Console.WriteLine(CancelAllOrder.ToString);
            Console.WriteLine();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

```

## Links

- [Homepage](https://github.com/Romulo-Meirelles)
- [NuGet Package](https://www.nuget.org/packages/BitnuvemAPI/)
- [Github Project](https://github.com/Romulo-Meirelles/Bitnuvem)
- [License](https://github.com/Romulo-Meirelles/Bitnuvem/blob/main/LICENSE)
- [Telegram](https://t.me/Romulo_Meirelles)
- [WhatsApp](https://wa.me/message/KWIS3BYO6K24N1)
- [UpWork](https://www.upwork.com/freelancers/~01fcbc5039ac5766b4)

