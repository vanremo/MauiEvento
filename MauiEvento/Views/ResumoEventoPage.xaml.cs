using MauiEvento.Models;

namespace MauiEvento.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage(Evento evento)
    {
        InitializeComponent();

        nomeLabel.Text = $"Nome: {evento.Nome}";
        dataLabel.Text = $"Início: {evento.DataInicio:dd/MM/yyyy} - Término: {evento.DataTermino:dd/MM/yyyy}";
        participantesLabel.Text = $"Participantes: {evento.NumeroParticipantes}";
        localLabel.Text = $"Local: {evento.Local}";
        duracaoLabel.Text = $"Duração: {evento.DuracaoEmDias} dias";
        custoTotalLabel.Text = $"Custo Total: R$ {evento.CustoTotal:F2}";
    }
}