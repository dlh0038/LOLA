namespace LOLA.Client.Pages{
    public partial class GetLunchTotal
    {   
        private Random rand = new Random();
        private double GetTotal()
        {
            return rand.Next(1000, 10000) / 100.0;
        }
    }
}