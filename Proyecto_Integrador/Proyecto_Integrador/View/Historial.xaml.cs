namespace Proyecto_Integrador.View;

public partial class Historial : ContentPage
{
	public Historial()
	{
		InitializeComponent();
	}



    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Videos());
    }

    private  async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Videos());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Videos());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Videos());
    }
}