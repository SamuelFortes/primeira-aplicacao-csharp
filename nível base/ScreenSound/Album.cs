class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, Genero genero)
    {
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }
    public int DuracaoTotalEmSegundos => musicas.Sum(m => m.DuracaoEmSegundos);
    public List<Musica> Musicas => musicas;
    public Genero Genero { get; set;}

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Álbum: {Nome}");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"  - {musica.Nome} ({musica.DuracaoEmSegundos / 60}:{musica.DuracaoEmSegundos % 60:D2})");
        }
        Console.WriteLine($"Duração total: {DuracaoTotalEmSegundos / 60}:{DuracaoTotalEmSegundos % 60:D2}");
    }
}
