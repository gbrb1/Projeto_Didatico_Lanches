using Microsoft.AspNetCore.Mvc;
using Projeto_Didatico_Lanches.Repositories.Interfaces;

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
            var lanches = this._lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
