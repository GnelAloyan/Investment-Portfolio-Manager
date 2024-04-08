using Xamarin.Forms;

namespace PortfolioManager
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
namespace PortfolioManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}