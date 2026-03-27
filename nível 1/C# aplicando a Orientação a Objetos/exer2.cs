/*
*/

//Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
class ContaBancaria
{
    public int identificacao;
    public string titular;
    public decimal saldo;
    public int senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo:C}");
    }
}

//Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
ContaBancaria conta1 = new();
conta1.titular = "Samuel";
conta1.saldo = 250.50m;
conta1.ExibirInformacoes();

//Desenvolver um método da classe Conta que exibe suas informações.
conta1.ExibirInformacoes();

//Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
class Carro
{
    public string ronco;
    public string freio;
    public string buzina;

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando: {ronco}");
    }

    public void Frear()
    {
        Console.WriteLine($"Freando: {freio}");
    }

    public void Buzinar()
    {
        Console.WriteLine($"Buzinando: {buzina}");
    }
}