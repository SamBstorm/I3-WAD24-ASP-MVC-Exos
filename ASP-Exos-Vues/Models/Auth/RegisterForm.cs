using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Exos_Vues.Models.Auth
{
    public class RegisterForm
    {
        [DisplayName("Prénom : ")]
        [Required(ErrorMessage = "Le champ 'Prénom' est obligatoire")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Le champ 'Prénom' doit être composé de 2 à 64 caractères.")]
        public string FirstName { get; set; }
        [DisplayName("Nom : ")]
        [Required(ErrorMessage = "Le champ 'Nom' est obligatoire")]
        [MinLength(2, ErrorMessage = "Le champ 'Nom' doit avoir au minimum 2 caractères.")]
        [MaxLength(64, ErrorMessage = "Le champ 'Nom' doit avoir au maximum 64 caractères.")]
        public string LastName { get; set; }
        [DisplayName("Date de naissance : ")]
        [Required(ErrorMessage = "Le champ 'Date de naissance' est obligatoire")]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }
        [DisplayName("Email : ")]
        [Required(ErrorMessage = "Le champ 'Email' est obligatoire")]
        [EmailAddress(ErrorMessage = "La valeur ne correspond pas au format d'une adresse e-mail valide")]
        public string Email { get; set; }
        [DisplayName("Mot de passe : ")]
        [Required(ErrorMessage = "Le champ 'Mot de passe' est obligatoire")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Le champ 'Mot de passe' doit avoir au minimum 8 caractères.")]
        [MaxLength(32, ErrorMessage = "Le champ 'Mot de passe' doit avoir au maximum 32 caractères.")]
        public string Password { get; set; }
        [DisplayName("Confirmation du mot de passe : ")]
        [Required(ErrorMessage = "Le champ 'Confirmation du mot de passe' est obligatoire")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Le champ 'Confirmation du mot de passe' doit correspondre au champ 'Mot de passe'.")]
        public string ConfirmPassword { get; set; }
    }
}
