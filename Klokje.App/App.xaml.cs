using Microsoft.Extensions.DependencyInjection;

using Klokje.App.Views;
using Klokje.App.ViewModels;

namespace Klokje.App;

public partial class App : Application
{
    public static IServiceProvider Services { get; private set; }

    public App(LoginViewModel loginViewModel, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        Services = serviceProvider;
        //MainPage = new AppShell();
        MainPage = new LoginView(loginViewModel);
    }
}