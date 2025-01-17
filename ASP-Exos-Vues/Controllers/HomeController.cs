using Microsoft.AspNetCore.Mvc;

namespace ASP_Exos_Vues.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
