// Agora é a sua vez! Crie mais um método que exiba apenas o nome e o artista usando interpolação de String.

class Musica
{
    public void ExibirFichaTecnica()
    {
        //código omitido…
    }

    public void ExibirFichaResumida()
    {
        Console.WriteLine(@$"Ficha Técnica Resumida:
Nome da Música: {Nome}
Nome do Artista: {Artista}");
    }
}