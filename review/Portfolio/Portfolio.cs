namespace PortfolioManager.Models
{
    public class Portfolio
    {
        public string Name { get; set; }
        public List<Asset> Assets { get; set; }

        public Portfolio(string name)
        {
            Name = name;
            Assets = new List<Asset>();
        }
    }
}
