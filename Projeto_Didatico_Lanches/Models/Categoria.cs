namespace Projeto_Didatico_Lanches.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public String CategoriaNome { get; set; }
    public String Descricao { get; set; }
    public List<Lanche> Lanches { get; set; }
}