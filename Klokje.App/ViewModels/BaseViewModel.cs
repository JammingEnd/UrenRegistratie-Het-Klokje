using CommunityToolkit.Mvvm.ComponentModel;
using Klokje.App.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klokje.App.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title = "";
        public virtual void Load() { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }

    }
}
