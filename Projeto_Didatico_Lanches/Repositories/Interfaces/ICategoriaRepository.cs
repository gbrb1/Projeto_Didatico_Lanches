using Projeto_Didatico_Lanches.Models;
namespace Projeto_Didatico_Lanches.Repositories.Interfaces;
public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}

