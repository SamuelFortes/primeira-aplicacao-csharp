class Banda
{
    public string Nome { get; set; }
    public List<Album> Albuns
    {
        get => _albuns;
        set
        {
            if(value == null || value.Count == 0)
            {
                Console.WriteLine("Não é permitido a adição de um álbum sem nenhuma informação.");
            }
            else
            {
                _albuns.Add(value);
            }
        }
    }
    private List<Album> _albuns = [];

    public Banda(string nome, List<Album> albuns)
    {
        Nome = nome;
        albuns = [];
    }
}