namespace Proyecto_Integrador.View;

public partial class Videos : ContentPage
{
	public Videos()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Historial());
    }
}