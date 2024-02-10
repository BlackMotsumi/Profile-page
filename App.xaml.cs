using ProfileScreen.Pages;

namespace ProfileScreen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProfilePage();
        }
    }
}
