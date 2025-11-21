using CommunityToolkit.Mvvm.ComponentModel;
using Klokje.App.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klokje.App.ViewModels
{
    public partial class TestViewModel : BaseViewModel
    {
        [ObservableProperty]
        string title = "";

        public override void Load()
        {

        }
        public override void OnAppearing()
        {

        }
        public override void OnDisappearing() 
        {

        }

    }
}
