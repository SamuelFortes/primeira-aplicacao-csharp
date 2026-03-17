using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

// Configura a codificação para aceitar acentos
Console.OutputEncoding = Encoding.UTF8;

// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

/*

Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>>()
{
    {"Samuel", [10,6,10]},
    {"Pedro", [10,10,9]},
    {"Lester", [7,0,10]}
};

Console.WriteLine("Lista de alunos registrados:");

foreach (KeyValuePair<string,List<int>> aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno.Key}");
    Console.Write("Notas: ");

    for (int i = 0; i < alunos[aluno.Key].Count(); i++)
    {
        Console.Write($"{alunos[aluno.Key][i]} ");
    }

    Console.Write("\n");
    Console.Write("Média: ");
    double mediaAluno = (double)alunos[aluno.Key].Sum() / alunos[aluno.Key].Count();
    Console.Write($"{mediaAluno:F2}");

    Console.Write("\n");
    Console.Write("\n");
    

};



// Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
    Dictionary<string, int> produtos = new Dictionary<string, int>{
      {"Panela", 10},
      {"Lanterna", 13}
    };

    Console.Write("Digite o nome de um produto do estoque e o sistema lhe mostrará sua quantidade em estoque: ");
    string nomeDoProduto = Console.ReadLine()!;

    if(produtos.ContainsKey(nomeDoProduto))
    {
      Console.WriteLine($"Quantidade em estoque do produto {nomeDoProduto}: {produtos[nomeDoProduto]} unidade(s)");
    }
    else
    {
      Console.Write("error");
    }



//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
    Dictionary<string, List<string>> quiz = new Dictionary<string, List<string>>{
      {"1. Qual é o maior planeta do Sistema Solar?", new List<string> {"Terra", "Marte", "Júpiter", "Saturno"}},
      {"2. Quem pintou a obra Mona Lisa?", new List<string> {"Vincent van Gogh", "Leonardo da Vinci", "Michelangelo", "Pablo Picasso"}}
    };

    Console.WriteLine("responda a 1° pergunta (digite apenas a letra da alternativa desejada) :");
    Console.WriteLine(quiz.ElementAt(0).Key);
    Console.WriteLine(@"
      A) Terra
      B) Marte
      C) Júpiter
      D) Saturno");
    string respostaDoUsuario1 = Console.ReadLine()!;

    switch(respostaDoUsuario1)
    {
    case "A":
      Console.WriteLine("Resposta errada!");
      break;

    case "B":
      Console.WriteLine("Resposta errada!");
      break;

    case "C":
      Console.WriteLine("Resposta certa!");
      break;

    case "D":
      Console.WriteLine("Resposta errada!");
      break;
    }

    Console.WriteLine("responda a 2° pergunta (digite apenas a letra da alternativa desejada) :");
    Console.WriteLine(quiz.ElementAt(1).Key);
    Console.WriteLine(@"
      A) Vincent van Gogh
      B) Leonardo da Vinci
      C) Michelangelo
      D) Pablo Picasso");
     string respostaDoUsuario2 = Console.ReadLine()!;

    switch(respostaDoUsuario2)
    {
    case "A":
      Console.WriteLine("Resposta errada!");
      break;

    case "B":
      Console.WriteLine("Resposta certa!");
      break;

    case "C":
      Console.WriteLine("Resposta errada!");
      break;

    case "D":
      Console.WriteLine("Resposta errada!");
      break;
    }



// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
    Dictionary<string,int> logins = new Dictionary<string,int>{
      {"Samuel", 24082005},
      {"João", 121212}
    };

    Console.WriteLine("Sistema de login");
    Console.Write("Nome de usuário: ");
    string usuario = Console.ReadLine()!;

    Console.Write("Senha: ");
    int senha = int.Parse(Console.ReadLine()!);

    if(logins.ContainsKey(usuario) || logins.ContainsValue(senha))
    {
      Console.WriteLine("Login efetuado com sucesso!");
    }
    else
    {
      Console.WriteLine("Nome de usuário ou senha incorretos!");
    }

*/



  
// Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>>
{
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

List<int> quantidadeDeVendas = new List<int>();
    
List<int> vendasDoCarro = new List<int>();
List<int> quantUnidadesVendas = new List<int>();
float media;
    

Console.WriteLine(@"Escolha um modelo de carro para calcular a média de quantas vezes esse carro foi vendido por ano (digite apenas o número correspondente ao carro) :
    1- Bugatti Veyron
    2- Koenigsegg Agera RS
    3- Lamborghini Aventador
    4- Pagani Huayra
    5- Ferrari LaFerrari");

int resposta = int.Parse(Console.ReadLine()!);

switch(resposta)
{
    case 1:
      vendasDoCarro = vendasCarros["Bugatti Veyron"];
      media = CalcularMedia(quantUnidadesVendas: vendasDoCarro);
      Console.WriteLine($"A média da quantidade de vendas por ano do modelo Bugatti Veyron foi de {media:F2}");
      break;

    case 2:
      vendasDoCarro = vendasCarros["Koenigsegg Agera RS"];
      media = CalcularMedia(quantUnidadesVendas: vendasDoCarro);
      Console.WriteLine($"A média da quantidade de vendas por ano do modelo Koenigsegg Agera RS foi de {media:F2}");
      break;

    case 3:
      vendasDoCarro = vendasCarros["Lamborghini Aventador"];
      media = CalcularMedia(quantUnidadesVendas: vendasDoCarro);
      Console.WriteLine($"A média da quantidade de vendas por ano do modelo Lamborghini Aventador foi de {media:F2}");
      break;

    case 4:
      vendasDoCarro = vendasCarros["Pagani Huayra"];
      media = CalcularMedia(quantUnidadesVendas: vendasDoCarro);
      Console.WriteLine($"A média da quantidade de vendas por ano do modelo Pagani Huayra foi de {media:F2}");
      break;

    case 5:
      vendasDoCarro = vendasCarros["Ferrari LaFerrari"];
      media = CalcularMedia(quantUnidadesVendas: vendasDoCarro);
      Console.WriteLine($"A média da quantidade de vendas por ano do modelo Ferrari LaFerrari foi de {media:F2}");
      break;
      

    default:
      Console.WriteLine("Digite um número entre 1 e 5!");
      break;
};

float CalcularMedia(List<int> quantUnidadesVendas)
{
      float somatorioVendas = quantUnidadesVendas.Sum();
      int quantVendas = quantUnidadesVendas.Count();

      float media = somatorioVendas / quantVendas;
      return media;
};