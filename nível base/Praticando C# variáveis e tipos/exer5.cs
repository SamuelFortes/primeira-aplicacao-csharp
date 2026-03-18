//Declare duas variáveis para a largura e comprimento, respectivamente.
float largura;
float comprimento;
Console.Write("Digite a largura do seu terreno: ");
largura = float.Parse(Console.ReadLine()!);
Console.Write("Digite o comprimento do seu terreno: ");
comprimento = float.Parse(Console.ReadLine()!);
//Aplique a fórmula mencionada para calcular a área do terreno.
float area = largura * comprimento;
//Exiba o resultado do cálculo.
Console.WriteLine($"A área do terreno é: {area} metros quadrados.");