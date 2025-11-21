using Microsoft.Extensions.DependencyInjection;

using Klokje.App.Views;
using Klokje.App.ViewModels;

namespace Klokje.App;

public partial class App : Application
{
    public App(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        //MainPage = new AppShell();
        MainPage = new LoginView(loginViewModel);
    }
}