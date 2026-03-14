// iniciando e rodando uma aplicação C#
// dotnet new console -o NomeDaAplicacao
// dotnet run

using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// List<string> listaDeBandas = [];
Dictionary<string, List<int>> dicionarioDeBandas = new Dictionary<string, List<int>>();

Console.WriteLine("SCREEN SOUND");
Console.WriteLine("\nBoas Vindas ao Screen Sound!");

void ExibirMenuPrincipal()
{
    int opcao;

    do
    {
        Console.WriteLine(@"
        1 - Registrar nova banda
        2 - Exibir todas as bandas
        3 - Avaliar uma banda
        4 - Exibir a média de uma banda
        -1 - Sair");

        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                RegistrarNovaBanda();
                break;

            case 2:
                MostrarTodasAsBandas();
                break;

            case 3:
                AvaliarBanda();
                break;

            case -1:
                break;

            default:
                Console.WriteLine("Opão Inválida!");
                break;
        }

    } while (opcao != -1);
}

ExibirMenuPrincipal();

void RegistrarNovaBanda()
{
    Console.Clear();

    ExibirTituloDaOpcao("Registro de ums nova banda");
    Console.Write("Digite o nome da nova banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDeBandas.Add(nomeDaBanda);
    dicionarioDeBandas.Add(nomeDaBanda, []);
    Thread.Sleep(1000);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
}

void MostrarTodasAsBandas()
{
    Console.Clear();

    ExibirTituloDaOpcao("Listando todas as bandas");
    Console.WriteLine("Lista de todas as bandas já registradas dentro do sistema:");
    Thread.Sleep(1000);

    /*
     for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"{i+1}° {listaDeBandas[i]}");
    }

    */

    foreach(KeyValuePair<string,List<int>> banda in dicionarioDeBandas)
    {
        Console.WriteLine($"- {banda.Key}");
    }

    Thread.Sleep(1000);

    Console.Write("Digite qualquer tecla para retornar ao menu principal:");
    Console.ReadKey();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string quantidadeDeAsteriscos = String.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(quantidadeDeAsteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(quantidadeDeAsteriscos);
    
}

void AvaliarBanda()
{
    Console.Clear();

    ExibirTituloDaOpcao("Avaliação de uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandaAvaliada = Console.ReadLine()!;

    if(dicionarioDeBandas.ContainsKey(bandaAvaliada))
    {
        Console.Write($"Digite a nota que deseja dar a banda {bandaAvaliada}: ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);
        dicionarioDeBandas[bandaAvaliada].Add(notaDaBanda);

        Thread.Sleep(1000);

        Console.WriteLine("Nota registrada com sucesso!");

    } else
    {
        Console.WriteLine($"A banda {bandaAvaliada} não está cadastrada!");
    }

    Thread.Sleep(1000);    
}