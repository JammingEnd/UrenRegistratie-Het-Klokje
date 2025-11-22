using Klokje.App;
using Klokje.App.ViewModels;
using Klokje.App.Views;

namespace Klokje.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
        Routing.RegisterRoute(nameof(NotificationView), typeof(NotificationView));
        Routing.RegisterRoute(nameof(ProjectsOverviewView), typeof(ProjectsOverviewView));
        Routing.RegisterRoute(nameof(WeekOverviewView), typeof(WeekOverviewView));
        Routing.RegisterRoute(nameof(TestView), typeof(TestView));
        Routing.RegisterRoute(nameof(NavigationView), typeof(NavigationView));
        Routing.RegisterRoute(nameof(InvoiceOverviewView), typeof(InvoiceOverviewView));

    }
}