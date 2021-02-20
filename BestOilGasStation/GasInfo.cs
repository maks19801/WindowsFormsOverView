namespace BestOilGasStation
{
    public class GasInfo
    {
        
        public GasInfo(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return Title;
        }

        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}
