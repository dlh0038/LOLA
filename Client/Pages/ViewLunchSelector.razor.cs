namespace LOLA.Client.Pages{
    public partial class ViewLunchSelector
    {
        private string msg = "Current Lunch Selector: ";
        private string[] Selectors = {"Chris", "Denny", "Emilio", "Garren", "Greg", "Hani", "Kari", "Kris", "Nicole", "Tammy","Tommi"};

        private string GetSelector()
        {
            Random Rand = new Random();
            return Selectors[Rand.Next(0,Selectors.Length)];
        }
    }
}