using MauiEvento.Models;

namespace MauiEvento.Views;

public partial class CadastroEventoPage : ContentPage
{
    private Evento evento;

    public CadastroEventoPage()
    {
        InitializeComponent();
        evento = new Evento
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today,
            NumeroParticipantes = 1
        };
        BindingContext = evento;
    }

    private async void OnCadastrarEventoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEventoPage(evento));
    }
}
