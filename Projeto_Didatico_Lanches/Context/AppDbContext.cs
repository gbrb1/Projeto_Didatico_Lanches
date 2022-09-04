using Microsoft.EntityFrameworkCore;
using Projeto_Didatico_Lanches.Models;

namespace Projeto_Didatico_Lanches.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Lanche> Lanches { get; set; }

}