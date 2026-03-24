int celsius; int fahrenheit;
        int celsiusToFahrenheit; int fahrenheitToCelsius;
        

        while(true)
        {
            Console.WriteLine(@"
                1 - Celsius para Fahrenheit
                2 - Fahrenheit para Celsius
                3 - Sair
                Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine()!);
            
            switch(opcao)
            {
            case 1:
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = int.Parse(Console.ReadLine()!);
                celsiusToFahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C equivalem a {celsiusToFahrenheit}°F");
                break;

            case 2:
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = int.Parse(Console.ReadLine()!);
                fahrenheitToCelsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F equivalem a {fahrenheitToCelsius}°C");
                break;

            case 3:
                break;

            default:
                Console.WriteLine("Digite uma opção do menu válida!");
                break;
            }
        }