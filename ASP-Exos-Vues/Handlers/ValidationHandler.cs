using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.RegularExpressions;

namespace ASP_Exos_Vues.Handlers
{
    public static class ValidationHandler
    {
        public static ModelStateDictionary RequiredAge(this ModelStateDictionary modelState, DateOnly birthdate, string name, int age = 18)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            if (birthdate > today.AddYears(-age))
            {
                modelState.AddModelError(name, $"Vous n'avez pas encore {age} ans.");
            }

            return modelState;
        }

        public static ModelStateDictionary RequiredUpperCase(this ModelStateDictionary modelState, string value, string name)
        {
            if(value is not null && !Regex.IsMatch(value, "[A-Z]"))
            {
                modelState.AddModelError(name, "Le champ doit contenir au minimum une majuscule.");
            }

            return modelState;
        }
        public static ModelStateDictionary RequiredLowerCase(this ModelStateDictionary modelState, string value, string name)
        {
            if (value is not null && !Regex.IsMatch(value, "[a-z]"))
            {
                modelState.AddModelError(name, "Le champ doit contenir au minimum une minuscule.");
            }

            return modelState;
        }
        public static ModelStateDictionary RequiredNumber(this ModelStateDictionary modelState, string value, string name)
        {
            if (value is not null && !Regex.IsMatch(value, "[0-9]"))
            {
                modelState.AddModelError(name, "Le champ doit contenir au minimum un chiffre.");
            }

            return modelState;
        }
        public static ModelStateDictionary RequiredSymbol(this ModelStateDictionary modelState, string value, string name)
        {
            /*if (value is not null && !Regex.IsMatch(value, @"[\-\\.+/*=@#§%\[\]]"))
            {
                modelState.AddModelError(name, @"Le champ doit contenir au minimum un des symboles suivant : -, \, ., +, /, *, =, @, #, §, %, [ ou ].");
            }*/
            RegexpValidation(modelState, value, name, @"[\-\\.+/*=@#§%\[\]]", @"Le champ doit contenir au minimum un des symboles suivant : -, \, ., +, /, *, =, @, #, §, %, [ ou ].");

            return modelState;
        }

        private static void RegexpValidation(this ModelStateDictionary modelState, string value, string name, string pattern, string errorMessage)
        {
            if (value is not null && !Regex.IsMatch(value, pattern))
            {
                modelState.AddModelError(name, errorMessage);
            }
        }
    }
}
