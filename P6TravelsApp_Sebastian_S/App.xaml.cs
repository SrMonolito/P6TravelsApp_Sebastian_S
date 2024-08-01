using P6TravelsApp_Sebastian_S.Views;

namespace P6TravelsApp_Sebastian_S
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
