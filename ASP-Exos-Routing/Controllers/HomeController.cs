using System.Diagnostics;
using ASP_Exos_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Exos_Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*
        [Route("/")]
        [Route("/Home")]
        [Route("/Home/Index")]
        [Route("/Accueil")]*/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Math/Multiple/{nb}")]
        public string[] Multiple(int nb)
        {
            string[] result = new string[10];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = $"{nb} X {i + 1} = {nb * (i + 1)}";
            }
            return result;
        }

        public string Aide()
        {
            return "Pour revenir à l'accueil, aller sur http://www.localhost:5134/";
        }

        public string Message(string text = "Aucun texte actuellement")
        {
            return text;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
