namespace MauiAppmeuhotel.Views;

public partial class Verificandohospedagem : ContentPage
{
	public Verificandohospedagem()
	{
		InitializeComponent();
	}
	private async void Btn_voltar_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}