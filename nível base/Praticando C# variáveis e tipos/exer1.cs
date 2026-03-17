using System;
using System.Text;
// Configura a codificação para aceitar acentos
Console.OutputEncoding = Encoding.UTF8;

//Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.
int anoAtual = DateTime.Now.Year;

Console.Write("Digite o ano em que você nasceu: ");
int anoDoUsuario = int.Parse(Console.ReadLine()!);

int idadeDoUsuario = anoAtual - anoDoUsuario;

Console.WriteLine($"Você possui {idadeDoUsuario} ano(s)!");