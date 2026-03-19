//Receba um valor representando o saldo.
double saldoBancario;
Console.Write("Digite o valor do seu saldo bancário: ");
saldoBancario = double.Parse(Console.ReadLine()!);
//Verifique se esse valor é positivo, negativo ou zero.
if(saldoBancario > 0)
{
    Console.WriteLine("O saldo está positivo.");
}
else if(saldoBancario < 0)
{
    Console.WriteLine("O saldo está negativo.");
}
else
{
    Console.WriteLine("O saldo está zerado.");
}