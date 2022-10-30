using Projeto_Didatico_Lanches.Context;
using Projeto_Didatico_Lanches.Models;
using Projeto_Didatico_Lanches.Repositories.Interfaces;

namespace Projeto_Didatico_Lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
