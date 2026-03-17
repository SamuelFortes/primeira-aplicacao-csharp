// 1- Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

using System;
using System.Text;


Console.OutputEncoding = Encoding.UTF8;

/*
Console.WriteLine("Operações básicas com números float:");
Console.Write("Digite o 1° número float: ");
float num1 = float.Parse(Console.ReadLine()!);
Console.Write("Digite o 2° número float: ");
float num2 = float.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("As 4 operações básicas:");
Console.WriteLine(@$"
adição: {num1} + {num2} = {num1+num2}
subtração: {num1} - {num2} = {num1-num2}
multiplicação: {num1} x {num2} = {num1*num2}
divisão: {num1} / {num2} = {num1/num2}");


// 2- Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> bandas = [];

bandas.Add("Banda 1");
bandas.Add("Banda 2");
bandas.Add("Banda 3");

// 3- Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

foreach(string banda in bandas)
{
    Console.WriteLine(banda);
}


// 4- Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
List<int> inteiros = [1,2,3,4,5,6,123];
int somaTotal = 0;

inteiros.ForEach(inteiro => somaTotal += inteiro);
Console.WriteLine($"Resultado da soma de todos os inteiros da lista: {somaTotal}");
*/

/*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.


List<int> inteiros = [1,2,3,4,5,6,7,8,9,10];
List<int> inteirosPares = [];
// solução 1
for (int i = 0; i < inteiros.Count; i++)
{
    if(inteiros[i]%2 == 0)
    {
        inteirosPares.Add(inteiros[i]);
    }
}

inteirosPares.ForEach(numero => Console.WriteLine(numero));
*/

// solução 2
List<int> inteiros = [1,2,3,4,5,6,7,8,9,10];
List<int> inteirosPares = [];

foreach (int inteiro in inteiros)
{
    if(inteiro%2 == 0)
    {
        inteirosPares.Add(inteiro);
    }
}

inteirosPares.ForEach(numero => Console.WriteLine(numero));