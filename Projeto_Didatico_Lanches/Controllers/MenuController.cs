using Microsoft.AspNetCore.Mvc;

namespace Projeto_Didatico_Lanches.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
