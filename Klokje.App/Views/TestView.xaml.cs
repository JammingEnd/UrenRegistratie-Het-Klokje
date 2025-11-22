using Klokje.App.ViewModels;

namespace Klokje.App.Views;

public partial class TestView : ContentPage
{
	public TestView()
	{
		InitializeComponent();
        BindingContext = new TestViewModel();
    }
}