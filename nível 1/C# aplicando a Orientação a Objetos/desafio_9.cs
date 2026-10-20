// Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

// para add um regra em uma property precisamos criar um campo de apoio privado

public class Carro
{
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano
    {
        get => _ano;
        set
        {
            if(value >= 1960 && value <= 2023)
            {
                _ano = value;
            }
            else
            {
                throw new ArgumentException("A propriedade Ano só aceita valores entre 1960 e 2023");
            }
        }
    }
    private int _ano;
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

// Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.

public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public decimal Preco
    {
        get => _preco;
        set
        {
            if (int.IsPositive(value))
            {
                _preco = value;
            }
            else
            {
                throw new ArgumentException("O valor da propriedade Preço deve ser positivo");
            }
        }
    }
    private decimal _preco;
    public int Estoque
    {
        get => _estoque;
        set
        {
            if (int.IsPositive(value))
            {
                _estoque = value;
            }
            else
            {
                throw new ArgumentException("O valor da propriedade Estoque deve ser positivo");
            }
        }
    }
    private int _estoque;
    public string Detalhamento => $"informações do produto:\nNome: {Nome}\nMarca: {Marca}\nPreço: {Preco}\nEstoque: {Estoque}";
}