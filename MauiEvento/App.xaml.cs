namespace MauiEvento;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell(); // Aqui ele deve reconhecer AppShell
    }
}