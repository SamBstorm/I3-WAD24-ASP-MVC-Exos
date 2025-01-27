using ASP_Exos_Vues.Handlers;
using ASP_Exos_Vues.Models.Auth;
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

        [HttpGet]
        public IActionResult Register()
        {
            Title += " - S'enregistrer";
            /*if (TempData.ContainsKey("message"))
            {
                return RedirectToAction(nameof(Login));
            }
            TempData["message"] = "Vous êtes maintenant enregistré!";*/
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            try
            {
                ModelState
                    .RequiredAge(form.BirthDate, nameof(form.BirthDate))
                    .RequiredLowerCase(form.Password, nameof(form.Password))
                    .RequiredUpperCase(form.Password, nameof(form.Password))
                    .RequiredNumber(form.Password, nameof(form.Password))
                    .RequiredSymbol(form.Password, nameof(form.Password));
                if (!ModelState.IsValid) throw new ArgumentException();
                //Envois les informations en BD
                TempData["message"] = "Vous êtes maintenant enregistré!";
                return RedirectToAction(nameof(Login));
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            Title += " - Se connecter";
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form) {
            Title += " - Se connecter";
            try
            {
                ModelState.RequiredLowerCase(form.Password, nameof(form.Password))
                        .RequiredUpperCase(form.Password, nameof(form.Password))
                        .RequiredNumber(form.Password, nameof(form.Password))
                        .RequiredSymbol(form.Password, nameof(form.Password));
                if (!ModelState.IsValid) throw new ArgumentException();
                //Vérifier si l'utilisateur est un utilisateur existant dans la DB
                return RedirectToAction(nameof(Index), "Home");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
