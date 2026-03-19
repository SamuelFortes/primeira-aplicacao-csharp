//Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
double pi = 3.14159;
//Declare uma variável que receba o valor do raio do círculo.
double raioDoCirculo;
Console.Write("Digite o valor do raio do círculo: ");
raioDoCirculo = double.Parse(Console.ReadLine()!);
//Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
double area = pi * (Math.Pow(raioDoCirculo, 2));
//Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
double perimetro = 2 * pi * raioDoCirculo;
//Exiba os resultados no console.
Console.WriteLine(@$"
    Raio: {raioDoCirculo} 
    Área do círculo: {area:F2} 
    Perímetro do círculo: {perimetro:F2} ");