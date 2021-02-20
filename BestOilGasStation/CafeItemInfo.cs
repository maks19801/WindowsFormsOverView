namespace BestOilGasStation
{
    public class CafeItemInfo
    {
        public CafeItemInfo(string title, decimal price)
        {
            Title = title;
            Price = price;
            Count = 0;

        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal CafeItemTotalPrice { get; set; }
    }
}
