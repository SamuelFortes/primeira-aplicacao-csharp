// definicao de classe: maneira de representar,a nível de código, uma entidade da vida real
// atributo: as caracteristicas de uma classe. EX: class Carro possui Cor, Peso, Modelo, Ano, ...
// método: as funcionalidades e ações que uma classe pode executar. EX: class Carro possui o atributo Buzinar()

// Como podemos representar no código a instância da classe EscolaDoRock e a execução do método que exibe o título e o ano de lançamento?

// instância da classe
EscolaDoRock escolaDoRock = new();

// execução do método que exibe o título e o ano de lançamento
escolaDoRock.ExibirInformacoes();

class EscolaDoRock
{
    public string titulo;
    public int anoLancamento;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Ano de Lançamento: {anoLancamento}");
    }
}