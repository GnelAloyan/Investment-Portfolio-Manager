using PortfolioManager.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PortfolioManager.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Portfolio> Portfolios { get; set; }
        public Portfolio SelectedPortfolio { get; set; }
        public ICommand AddPortfolioCommand { get; }

        public MainViewModel()
        {
            Portfolios = new ObservableCollection<Portfolio>();

            // Example portfolios
            Portfolios.Add(new Portfolio("Tech Stocks"));
            Portfolios.Add(new Portfolio("Real Estate"));

            AddPortfolioCommand = new Command(AddPortfolio);
        }

        void AddPortfolio()
        {
            // Add new portfolio logic here
        }
    }
}
