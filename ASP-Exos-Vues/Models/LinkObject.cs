namespace ASP_Exos_Vues.Models
{
    public struct LinkObject
    {
        public string Text { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }

        public LinkObject(string text, string? action = null, string? controller = null)
        {
            Text = text;
            Controller = controller;
            Action = action;
        }
    }
}
