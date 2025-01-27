using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Exos_Vues.Models.Auth
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Le champ Email est obligatoire.")]
        [DisplayName("Email : ")]
        [EmailAddress(ErrorMessage = "Le champ Email ne correspond pas au bon format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Le champ Mot de passe est obligatoire.")]
        [DisplayName("Mot de passe : ")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Le champ Mot de passe doit contenir au minimum 8 caractères")]
        [MaxLength(32, ErrorMessage = "Le champ Mot de passe doit contenir au maximum 32 caractères")]
        //[RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\-\\.+/*=@#§%\[\]]).{8,32}", ErrorMessage = "Le champ Mot de passe ne correspond pas au bon format.")]
        public string Password { get; set; }
    }
}
