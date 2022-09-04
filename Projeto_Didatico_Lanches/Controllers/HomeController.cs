using Microsoft.AspNetCore.Mvc;
using Projeto_Didatico_Lanches.Models;
using System.Diagnostics;

namespace Projeto_Didatico_Lanches.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}