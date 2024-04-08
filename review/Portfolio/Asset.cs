namespace PortfolioManager.Models
{
    public class Asset
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public decimal TotalValue => Quantity * PricePerUnit;
    }
}
