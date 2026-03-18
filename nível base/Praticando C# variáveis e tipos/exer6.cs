//Declare três variáveis do tipo float para armazenar as notas dos alunos. Foi fornecido pela escola os seguintes valores (7.2, 8.3 e 9.1)
float nota1;
float nota2;
float nota3;
Console.Write("Digite sua 1° nota: ");
nota1 = float.Parse(Console.ReadLine()!);
Console.Write("Digite sua 2° nota: ");
nota2 = float.Parse(Console.ReadLine()!);
Console.Write("Digite sua 3° nota: ");
nota3 = float.Parse(Console.ReadLine()!);
//Calcule a média aritmética das três.
float mediaDoAluno = (nota1 + nota2 + nota3) / 3;
//Exiba a média calculada.
Console.WriteLine($"A média das notas é: {mediaDoAluno}");