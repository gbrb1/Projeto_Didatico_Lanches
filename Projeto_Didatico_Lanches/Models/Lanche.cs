﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Didatico_Lanches.Models;
[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "o {0} deve ter no minimo entre {1} e maximo {2} caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
    [Display(Name = "Descrição do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
    public string DescricaoCurta { get; set; }
    [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informado")]
    [Display(Name = "Descrição detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição detalhada deve ter no máximo {1} caracteres")]
    public string DescricaoDetalhada { get; set; }
    [Required(ErrorMessage = "O preço do lanche deve ser informado")]
    [Display(Name = "Preço do Lanche")]
    [Column(TypeName = "decimal(4, 2)")]
    [Range(0.01, 9999.99, ErrorMessage = "O preço deve estar entre {1} e {2}")]
    public Decimal Preco { get; set; }
    [Display(Name = "Caminho imagem normal")]
    [StringLength(200, ErrorMessage = "o {0} deve ter no maximo {1} caracteres")]
    public string ImagemUrl { get; set; }
    [Display(Name = "Caminho imagem miniatura")]
    [StringLength(200, ErrorMessage = "o {0} deve ter no maximo {1} caracteres")]
    public string ImagemThumbnailUrl { get; set; }
    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }
    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }
    //[ForeignKey]
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}

