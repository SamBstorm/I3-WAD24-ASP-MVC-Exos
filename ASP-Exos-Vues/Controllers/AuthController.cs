using Microsoft.AspNetCore.Mvc;

namespace ASP_Exos_Vues.Controllers
{
    public class AuthController : Controller
    {
        [ViewData]
        public string Title { get; set; } = "Accès membre";
        public IActionResult Index()
        {
            return RedirectToAction("Register");
        }

        public IActionResult Register()
        {
            Title += " - S'enregistrer";
            if (TempData.ContainsKey("message"))
            {
                return RedirectToAction(nameof(Login));
            }
            TempData["message"] = "Vous êtes maintenant enregistré!";
            return View();
        }

        public IActionResult Login()
        {
            Title += " - Se connecter";
            return View();
        }
    }
}
