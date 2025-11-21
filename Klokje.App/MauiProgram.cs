using Microsoft.Extensions.Logging;
using Klokje.App.Views;
using Klokje.App.ViewModels;
using Klokje.Core.Interfaces.Repositories;
using Klokje.Core.Data.Repositories;
using Klokje.Core.Interfaces.Services;
using Klokje.Core.Services;
using CommunityToolkit.Maui;


using Microsoft.Maui.Hosting;



namespace Klokje.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IAuthService, AuthService>();
        builder.Services.AddSingleton<IClientService, ClientService>();


        builder.Services.AddSingleton<IClientRepository, ClientRepository>();
        builder.Services.AddSingleton<GlobalViewModel>();

        builder.Services.AddTransient<TestView>().AddTransient<TestViewModel>();
        builder.Services.AddTransient<LoginView>().AddTransient<LoginViewModel>();
        builder.Services.AddTransient<WeekOverviewView>().AddTransient<WeekOverviewViewModel>();
        builder.Services.AddTransient<ProjectsOverviewView>().AddTransient<ProjectsOverviewViewModel>();
        builder.Services.AddTransient<NotificationView>().AddTransient<NotificationViewModel>();

        return builder.Build();
    }
}