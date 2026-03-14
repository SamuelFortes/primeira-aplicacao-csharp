/*
Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
*/

// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

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