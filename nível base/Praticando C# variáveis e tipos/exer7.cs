//Receber o peso total em toneladas (decimal)
        decimal toneladas;
        Console.Write("Digite o peso total da carga, em toneladas: ");
        toneladas = decimal.Parse(Console.ReadLine()!);
        //Converter para inteiro descartando a parte decimal
        int toneladasValorInteiro = (int)toneladas;
        //Exibir a quantidade mínima de veículos necessários
        Console.WriteLine($"Veículos necessários: {toneladasValorInteiro} ");