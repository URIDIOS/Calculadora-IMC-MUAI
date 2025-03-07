using PROYECTO_TROU_MVVM.ViewModels;

namespace PROYECTO_TROU_MVVM.View;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
        BindingContext = new RegistroViewModel();
    }
}