using PROYECTO_TROU_MVVM.ViewModels;

namespace PROYECTO_TROU_MVVM.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}