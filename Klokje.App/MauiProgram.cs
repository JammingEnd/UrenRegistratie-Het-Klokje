using Microsoft.Extensions.Logging;
using Klokje.App.Views;
using Klokje.App.ViewModels;

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

        builder.Services.AddTransient<TestView>().AddTransient<TestViewModel>();
        builder.Services.AddTransient<LoginView>().AddTransient<LoginViewModel>();
        builder.Services.AddTransient<WeekOverviewView>().AddTransient<WeekOverviewViewModel>();
        builder.Services.AddTransient<ProjectsOverviewView>().AddTransient<ProjectsOverviewViewModel>();
        builder.Services.AddTransient<ProjectsOverviewView>().AddTransient<ProjectsOverviewViewModel>();

        return builder.Build();
    }
}