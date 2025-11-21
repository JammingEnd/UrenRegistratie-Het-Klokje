using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Klokje.App.ViewModels
{
    public partial class NavigationViewModel : BaseViewModel
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

        public bool WeekOverviewIsVisible { get; set; } = true;
        public bool ProjectOverviewIsVisible { get; set; } = true;
    }
}
