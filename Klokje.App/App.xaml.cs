using Microsoft.Extensions.DependencyInjection;

using Klokje.App.Views;

namespace Klokje.App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}