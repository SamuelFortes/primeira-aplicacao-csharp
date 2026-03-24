        int estoqueAtual = 0;
        Console.WriteLine(@"Deseja adicionar um produto ao estoque?
1 - Sim | 0 - Não");
        int respostaUsuario = int.Parse(Console.ReadLine()!);

        while(respostaUsuario == 1)
        {
                Console.Write("Quantidade: ");
                int estoque = int.Parse(Console.ReadLine()!);
                estoqueAtual += estoque;
                Console.WriteLine($"Estoque atual: {estoqueAtual}");

                Console.WriteLine(@"Deseja continuar?
1 - Sim | 0 - Não");
                int respostaUsuario2 = int.Parse(Console.ReadLine()!);

                if(respostaUsuario2 == 0)
                {
                    Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
                    break;
                }
        }