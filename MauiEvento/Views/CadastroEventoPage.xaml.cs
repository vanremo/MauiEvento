using MauiEvento.Models;

namespace MauiEvento.Views;

public partial class CadastroEventoPage : ContentPage
{
    public Evento EventoAtual { get; set; } = new();

    public List<string> TiposEvento { get; set; } = new()
    {
        "Google Developer Conference",
        "Workshop de Tecnologia e Inovação",
        "Inovação e Empreendedorismo"
    };

    public List<string> LocaisDisponiveis { get; set; } = new()
    {
        "Expo Center São Paulo-SP",
        "Florianópolis-SC",
        "Porto Alegre-RS"
    };

    public CadastroEventoPage()
    {
        InitializeComponent();
        BindingContext = this;

        EventoAtual.Nome = TiposEvento.First();
        EventoAtual.Local = LocaisDisponiveis.First();
    }

    private async void OnCadastrarEventoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEventoPage(EventoAtual));
    }
}