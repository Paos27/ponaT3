using ponaT3.Vistas;

namespace ponaT3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.vLogin());
        }
    }
}
