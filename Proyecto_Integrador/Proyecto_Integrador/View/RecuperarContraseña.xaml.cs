using PROYECTO_TROU_MVVM.ViewModels;

namespace PROYECTO_TROU_MVVM.View;

public partial class RecuperarContraseña : ContentPage
{
	public RecuperarContraseña()
	{
		InitializeComponent();
		BindingContext = new RecuperarContraseñaViewModel();
	}
}