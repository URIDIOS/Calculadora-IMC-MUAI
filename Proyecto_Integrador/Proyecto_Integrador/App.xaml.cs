using PROYECTO_TROU_MVVM.View;

namespace Proyecto_Integrador
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
		}
    }
}
