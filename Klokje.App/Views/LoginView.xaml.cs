using Klokje.App.ViewModels;

namespace Klokje.App.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

	private void OnLoginClicked(object sender, EventArgs ev)
	{
        Application.Current.MainPage = new AppShell();
    }
}