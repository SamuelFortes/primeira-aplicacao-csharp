// iniciando e rodando uma aplicação C#
// dotnet new console -o NomeDaAplicacao
// dotnet run

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

Dictionary<string, List<int>> dicionarioDeBandas = new Dictionary<string, List<int>>();
Dictionary<string, List<Album>> albunsPorBanda = new Dictionary<string, List<Album>>();

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
            5 - Registrar álbum de uma banda
            6 - Exibir álbuns de uma banda
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

                case 4: 
                    ExibirMediaBanda();
                    break;

                case 5:
                    RegistrarAlbum();
                    break;

                case 6:
                    ExibirAlbunsDaBanda();
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
        dicionarioDeBandas.Add(nomeDaBanda, new List<int>());
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

    void ExibirMediaBanda()
    {
      Console.Clear();

      ExibirTituloDaOpcao("Calculando a média de avaliações de uma banda");
      Console.Write("\n");
      Console.Write("Digite o nome da banda cuja a média de avaliações você quer que seja exibida: ");
      string bandaEscolhidaMedia = Console.ReadLine()!;

      if(dicionarioDeBandas.ContainsKey(bandaEscolhidaMedia))
      {
        if(dicionarioDeBandas[bandaEscolhidaMedia].Count() == 0)
        {
          Console.WriteLine($"A banda {bandaEscolhidaMedia} foi registrada dentro do sistema, porém ainda não possui nenhuma avaliação!");
        }

        float somatorioNotasAvaliacoes = dicionarioDeBandas[bandaEscolhidaMedia].Sum();
        int quantidadeAvaliacoes = dicionarioDeBandas[bandaEscolhidaMedia].Count();
        float mediaBanda = somatorioNotasAvaliacoes / quantidadeAvaliacoes;

        Thread.Sleep(1000);

        Console.WriteLine($"A média de avalições da banda {bandaEscolhidaMedia} é de: {mediaBanda:F2}");
      }
      else
      {
        Console.WriteLine($"A banda {bandaEscolhidaMedia} ainda não foi registrada dentro do sistema!");
      }
    }

    void RegistrarAlbum()
    {
        Console.Clear();

        ExibirTituloDaOpcao("Registro de um álbum");
        Console.Write("Digite o nome da banda detentora do álbum: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (!dicionarioDeBandas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine($"A banda {nomeDaBanda} não está cadastrada!");
            Thread.Sleep(1000);
            return;
        }

        Console.Write("Digite o nome do álbum: ");
        string nomeDoAlbum = Console.ReadLine()!;
        Console.Write("Digite o gênero do álbum: ");
        Genero generoDoAlbum = new(Console.ReadLine()!);
        Album album = new(nomeDoAlbum, generoDoAlbum);

        string continuar;
        do
        {
            Console.Write("Nome da música: ");
            string nomeDaMusica = Console.ReadLine()!;
            Console.Write("Duração da música (em segundos): ");
            int duracao = int.Parse(Console.ReadLine()!);
            Genero generoDaMusica = generoDoAlbum;

            album.AdicionarMusica(new Musica(nomeDaMusica, nomeDaBanda, duracao, generoDaMusica));

            Console.Write("Adicionar outra música? (s/n): ");
            continuar = Console.ReadLine()!;
        } while (continuar.ToLower() == "s");

        if (!albunsPorBanda.ContainsKey(nomeDaBanda))
        {
            albunsPorBanda.Add(nomeDaBanda, new List<Album>());
        }
        albunsPorBanda[nomeDaBanda].Add(album);

        Console.WriteLine($"O álbum {album.Nome} foi registrado com sucesso!");
        Thread.Sleep(1000);
    }

    void ExibirAlbunsDaBanda()
    {
        Console.Clear();

        ExibirTituloDaOpcao("Álbuns de uma banda");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (albunsPorBanda.ContainsKey(nomeDaBanda))
        {
            foreach (Album album in albunsPorBanda[nomeDaBanda])
            {
                Console.WriteLine();
                album.ExibirMusicasDoAlbum();
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não possui álbuns registrados!");
        }

        Console.Write("\nDigite qualquer tecla para retornar ao menu principal:");
        Console.ReadKey();
    }