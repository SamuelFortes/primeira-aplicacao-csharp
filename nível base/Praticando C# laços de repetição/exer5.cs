int opcaoMenu = 0;
        int senha = 000;
        int[] senhaAtual = new int[3];
        int count = 0;
        do
        {
            Console.WriteLine(@"
                1 - Gerar nova senha
                2 - Chamar próxima senha
                3 - Sair");
            opcaoMenu = int.Parse(Console.ReadLine()!);

            if(opcaoMenu == 1)
            {
                senha += 1;
                Console.Write($"Senha gerada: {senha.ToString("D3")}");
                senhaAtual[count] = senha;
                count++;
            }
            else if(opcaoMenu == 2)
            {
                foreach(int s in senhaAtual)
                    {
                        Console.Write($"Senha chamada: {s}");
                        senhaAtual.toList();
                    }
                Console.Write($"Senha chamada: {senha}");
            }
            else if(opcaoMenu == 0)
            {
                Console.WriteLine("Nehuma senha foi gerada ainda!");
            }
        }
        while(opcaoMenu != 3);