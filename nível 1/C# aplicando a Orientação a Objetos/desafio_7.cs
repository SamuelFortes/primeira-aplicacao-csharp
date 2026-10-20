// Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
Conta conta = new();
conta.Titular = "Samuel";
conta.Saldo = 1000;
conta.Senha = 24082005;
Console.WriteLine("informações: " + "\n" + "Titular: " + conta.Titular + "\n" + "Saldo: " + conta.Saldo);

// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// Desenvolver um método da classe Conta que exibe suas informações.
public class Conta
{
    public Guid Id { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine(@$"Informações do Propietário:
Titular: {Titular}
Saldo: {Saldo}");
    }
}


// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
public class Carro
{
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Ronco { get; set; }
    public string Freio { get; set; }
    public string Buzina { get; set; }

    public void Acelerar()
    {
        Ronco = "Roncando";
        Console.WriteLine(Ronco);
    }

    public void Frear()
    {
        Freio = "Freando";
        Console.WriteLine(Freio);
    }

    public void Buzinar()
    {
        Buzina = "biiii";
        Console.WriteLine(Buzina);
    }
}
