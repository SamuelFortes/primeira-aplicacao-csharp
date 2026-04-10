// Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
class ContaBancaria
{
    public int Identificacao {get; set;}
    public string Titular {get; set;}
    public decimal Saldo {get; set;}
    public int Senha {get; set;}

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo:C}");
    }
}

// Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
class Carro
{
    public string Ronco {get; set;}
    public string Freio {get; set;}
    public string Buzina {get; set;}
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {get; set;}
    public string DescricaoDetalhada => $"Fabricante: {Fabricante}\nModelo: {Modelo}\nAno do carro:{Ano}";

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando: {Ronco}");
    }

    public void Frear()
    {
        Console.WriteLine($"Freando: {Freio}");
    }

    public void Buzinar()
    {
        Console.WriteLine($"Buzinando: {Buzina}");
    }
}

// Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
private int _ano;

public int Ano
    {
        get
        {
            return _ano;
        }
        
        set
        {
            if(value >= 1960 && value <= 2023)
            {
                _ano = value;
            }
        }
    }

// Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
class Produto
{
    public string Nome {get; set;}
    public string Marca {get; set;}
    private float _preco;
    public float Preco
    {
        get
        {
            return _preco;
        }
        
        set
        {
            if(value >= 0)
            {
                _preco = value;
            }
        }
    }
    
    private int _estoque;
    public int Estoque 
    {
        get
        {
            return _estoque;
        }
        
        set
        {
            if(value >= 0)
            {
                _estoque = value;
            }
        }
    }

    public string DetalhamentoProduto => @$"
    Nome do produto: {Nome}
    Marca do produto: {Marca}
    Preço do produto: {Preco}
    Quantidade disponível no estoque: {Estoque}";
}
