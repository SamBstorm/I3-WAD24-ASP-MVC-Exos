using Microsoft.AspNetCore.Mvc;

namespace ASP_Exos_Vues.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; }= "Interface 3";
        public IActionResult Index()
        {
            Title += " - Accueil";
            return View();
        }

        public IActionResult Contact()
        {
            Title += " - Nous contacter";
            return View();
        }
    }
}
