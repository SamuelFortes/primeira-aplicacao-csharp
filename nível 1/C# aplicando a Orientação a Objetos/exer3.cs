class Musica
{
    public string Nome {get; set;}
    public string Artista {get; set;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}
    public int DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        string ficha = $"Nome do artista: {Artista}\nNome da música: {Nome}";
        //código omitido…
        Console.WriteLine(ficha);
    
    }
}