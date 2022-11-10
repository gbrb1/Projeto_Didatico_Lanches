using Microsoft.AspNetCore.Mvc;
using Projeto_Didatico_Lanches.Repositories.Interfaces;
using Projeto_Didatico_Lanches.ViewModels;

namespace Projeto_Didatico_Lanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            this._lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //ViewData["Title"] = "Todos os Lanches";
            //ViewData["Data"] = DateTime.Now;
            //var lanches = this._lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            //ViewBag.Total = "Total de lanches: ";
            //ViewBag.TotalLanches = totalLanches;
            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = this._lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }

    }
}
