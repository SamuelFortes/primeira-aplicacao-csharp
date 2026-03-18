//Declare uma variável que receba o valor das milhas.
int quantidadeDeMilhas;
Console.Write("Digite a quantidade de milhas que você quer converter para quilômetros: ");
quantidadeDeMilhas = int.Parse(Console.ReadLine()!);
//Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
double milhasToKm = quantidadeDeMilhas * 1.60934;
//Exiba o resultado no console.
Console.WriteLine($"{quantidadeDeMilhas} equivalem a {milhasToKm} quilômetros.");