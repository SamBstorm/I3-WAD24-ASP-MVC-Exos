namespace ASP_Exos_Vues.Models
{
    public class PhoneNumber
    {
        public string Number { get; set; }
        public string International { get; set; }

        public override string ToString()
        {
            return International + Number.Replace(" ", "").Substring(1);
        }
    }
}
