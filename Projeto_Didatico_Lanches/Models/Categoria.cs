using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Didatico_Lanches.Models;
[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    [StringLength(100, ErrorMessage = "Tamanho max 100 caracteres")]
    [Required(ErrorMessage = "Nome da categoria obrigatorio")]
    [Display(Name = "Nome")]
    public String CategoriaNome { get; set; }
    [StringLength(200, ErrorMessage = "Tamanho max 200 caracteres")]
    [Required(ErrorMessage = "Descrição obrigatoria")]
    [Display(Name = "Nome")]
    public String Descricao { get; set; }
    public List<Lanche> Lanches { get; set; }
}