using Microsoft.EntityFrameworkCore;
using Projeto_Didatico_Lanches.Context;
using Projeto_Didatico_Lanches.Models;
using Projeto_Didatico_Lanches.Repositories.Interfaces;

namespace Projeto_Didatico_Lanches.Repositories
{
    public class LancheRepository : ILancheRepository

    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Lanche> Lanches => this._context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => this._context.Lanches
            .Where(l => l.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return this._context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
