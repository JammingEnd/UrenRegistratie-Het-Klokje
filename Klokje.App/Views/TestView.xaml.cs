using Klokje.App.ViewModels;

namespace Klokje.App.Views;

public partial class TestView : ContentPage
{
	public TestView()
	{
		InitializeComponent();
        BindingContext = new TestViewModel();
    }

    private void OnWeekOverviewClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new WeekOverviewView();
    }

    private void OnProjectOverviewClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new ProjectsOverviewView();
    }
    private void OnNotificationClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NotificationView();
    }
    private void OnAccountClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new TestView();
    }
}