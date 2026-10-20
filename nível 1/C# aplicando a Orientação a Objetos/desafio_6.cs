// Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<int> Notas { get; set; }
}

public class Professor
{
    public string Nome { get; set; }
    public List<Disciplina> Disciplina { get; set; }
}

public class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; }
}

// Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

public class Restaurante
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Mesa> Mesa { get; set; }
    public Cardapio Cardapio { get; set; } 
}

public class Mesa
{
    public int Numero { get; set; }
    public bool EstaReservada { get; set; }
}

public class Cardapio
{
    public List<string> Pratos { get; set; }
}

public class Pedido
{
    public Mesa Mesa { get; set; }
    public List<> ItensDoCardapio { get; set; }
}