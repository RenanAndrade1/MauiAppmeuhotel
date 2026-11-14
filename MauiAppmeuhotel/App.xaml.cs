using MauiAppmeuhotel.Models;

namespace MauiAppmeuhotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
                new Quarto()
                {
                    Descricao = "Quarto super Luxo",
                    ValorDiariaAdulto = 300.0,
                    ValorDiariaCrianca = 150.0
                },
                new Quarto()
                {
                    Descricao = "Quarto Standard",
                    ValorDiariaAdulto = 150.0,
                    ValorDiariaCrianca = 75.0
                },
                new Quarto()
                {
                    Descricao = "Quarto Econômico",
                    ValorDiariaAdulto =  100.0,
                    ValorDiariaCrianca = 50.0
                }
        };
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.Suahospedagem()));
        }
    }
}