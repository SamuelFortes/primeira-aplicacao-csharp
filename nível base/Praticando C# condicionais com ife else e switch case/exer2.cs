//Receba um código numérico (1 ou 2) representando o tipo de produto.
        int tipoDeProduto;
        Console.WriteLine(@"
            “Perecível” para código 1.
            “Não perecível” para código 2.");
        Console.Write("\n");
        Console.Write("Digite o código do produto (1 ou 2): ");
        tipoDeProduto = int.Parse(Console.ReadLine()!);
        /*Classifique o produto como:
        “Perecível” para código 1.
        “Não perecível” para código 2.*/
        if(tipoDeProduto == 1)
        {
            Console.WriteLine("Perecível");
        }
        else if(tipoDeProduto == 2)
        {
            Console.WriteLine("Não Perecível");
        }
        else
        {
            Console.WriteLine("Código inválido");
        }