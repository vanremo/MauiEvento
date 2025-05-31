using System.ComponentModel;

namespace MauiEvento.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome;
        private DateTime dataInicio = DateTime.Today;
        private DateTime dataTermino = DateTime.Today;
        private int numeroParticipantes = 1;
        private string local;
        private double custoPorParticipante = 250.00;

        public string Nome
        {
            get => nome;
            set
            {
                if (nome != value)
                {
                    nome = value;
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set
            {
                if (dataInicio != value)
                {
                    dataInicio = value;
                    OnPropertyChanged(nameof(DataInicio));
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set
            {
                if (dataTermino != value)
                {
                    dataTermino = value;
                    OnPropertyChanged(nameof(DataTermino));
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set
            {
                if (numeroParticipantes != value)
                {
                    numeroParticipantes = value;
                    OnPropertyChanged(nameof(NumeroParticipantes));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public string Local
        {
            get => local;
            set
            {
                if (local != value)
                {
                    local = value;
                    OnPropertyChanged(nameof(Local));
                }
            }
        }

        public double CustoPorParticipante
        {
            get => custoPorParticipante;
            set
            {
                if (custoPorParticipante != value)
                {
                    custoPorParticipante = value;
                    OnPropertyChanged(nameof(CustoPorParticipante));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public int DuracaoEmDias => (int)(DataTermino - DataInicio).TotalDays + 1;

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}