using Projeto_Didatico_Lanches.Models;

namespace Projeto_Didatico_Lanches.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
