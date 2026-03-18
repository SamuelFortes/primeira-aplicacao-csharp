//Declarar uma variável com o número inicial de vidas.
int vidas;
Console.Write("Digita sua quantidade inicial de vidas: ");
vidas = int.Parse(Console.ReadLine()!);
//Simular uma situação em que o jogador erra.
Console.WriteLine($"Você errou! acaba de perder uma vida.");
vidas -= 1;
//Simular que o jogador acerta duas vezes.
Console.WriteLine($"Você Acertou 2 vezes! acaba de ganhar 2 vidas.");
vidas += 2;
//Armazene o valor final das vidas em uma nova variável.
int vidasRestantes = vidas;
Console.WriteLine($"Vidas finais: {vidasRestantes} ");