//Declare uma variável para armazenar o valor recebido da doação.
    float doacao;
//Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
bool isAnonima;
//Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
string tipoDeConta;

Console.Write("Qual valor você quer doar: ");
doacao = float.Parse(Console.ReadLine()!);

Console.Write("Sua doação será anônima: ");
isAnonima = bool.Parse(Console.ReadLine()!);

Console.Write("Qual o tipo de conta onde a doação será depositada (Use P para conta poupança e Use C para conta corrente) : ");
tipoDeConta = Console.ReadLine()!;

Console.WriteLine(@$"
    Valor recebido: R${doacao}
    Doação anônima: {isAnonima}
    Tipo de conta: {tipoDeConta}");