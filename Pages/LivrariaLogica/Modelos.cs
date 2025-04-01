

public class Livro
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Autor { get; set; }
    public string Editora { get; set; }
    public int Ano { get; set; }
    public string Genero { get; set; }
    public string ISBN { get; set; }
    public int Paginas { get; set; }
    public string Idioma { get; set; }
    public string Descricao { get; set; }
    public string Capa { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public bool Ativo { get; set; }
}