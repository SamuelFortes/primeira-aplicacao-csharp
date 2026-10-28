class Musica
{
    public Musica(string nome, string artista, int duracaoEmSegundos, Genero genero)
    {
        Nome = nome;
        Artista = artista;
        DuracaoEmSegundos = duracaoEmSegundos;
        Genero = genero;
    }

    public string Nome { get; }
    public string Artista { get; }
    public int DuracaoEmSegundos { get; }
    public Genero Genero { get; set;}

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {DuracaoEmSegundos / 60}:{DuracaoEmSegundos % 60:D2}");
    }
}
