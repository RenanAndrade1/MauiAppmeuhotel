namespace MauiAppmeuhotel.Views;

public partial class Suahospedagem : ContentPage
{
    App PropriedadesApp;
	public Suahospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(3);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date + TimeSpan.FromDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date + TimeSpan.FromDays(30);
    }

    private async void Btn_sobre_clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.Sobre());
    }
	private async void Btn_proximo_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Verificandohospedagem());
    }
    private async void Btn_nossoshoteis_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Nossoshoteis());
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin + TimeSpan.FromDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin + TimeSpan.FromDays(30);
    }
}