namespace MauiAppmeuhotel.Views;

public partial class Suahospedagem : ContentPage
{
	public Suahospedagem()
	{
		InitializeComponent();
	}

    private async void Btn_sobre_clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.Sobre());
    }
}