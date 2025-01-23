using ASP_Exos_Vues.Models;
using ASP_Exos_Vues.Models.Home;
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
            Address i3address = new Address() { 
                Street = "Rue Gaucheret",
                Number = "88",
                ZipCode = 1030,
                City = "Bruxelles",
                Country = "Belgique"
            };
            PhoneNumber i3phone = new PhoneNumber
            {
                Number = "02 219 15 10",
                International = "+32"
            };
            ContactViewModel model = new ContactViewModel() { 
                Address = i3address,
                Phone = i3phone
            };
            //Pas de type anonyme! Cela fonctionne du côté de l'action, mais pas du côté de la vue cshtml
            //var anonymousType = new { Address = i3address, Phone = i3phone };
            return View(model);
        }
    }
}
