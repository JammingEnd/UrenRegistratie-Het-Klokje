using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using Klokje.Core.Models;

namespace Klokje.App.ViewModels
{
    public partial class NavigationViewModel : BaseViewModel
    {
        [ObservableProperty]
        string title = "";

        public bool WeekOverviewIsVisible { get; set; }
        public bool ProjectOverviewIsVisible { get; set; }
        public bool StatisticsIsVisible { get; set; }
        public bool InvoiceOverviewIsVisible { get; set; }

        public NavigationViewModel(GlobalViewModel global)
        {
            SetButtonVisibility(global);
        }

        private void SetButtonVisibility(GlobalViewModel global)
        {
            if (global?.Client == null)
            {
                WeekOverviewIsVisible = false;
                ProjectOverviewIsVisible = false;
                StatisticsIsVisible = false;
                InvoiceOverviewIsVisible = false;
                return;
            }

            var role = global.Client.Role;

            switch (role)
            {
                case ClientRole.Employee:
                    WeekOverviewIsVisible = true;
                    ProjectOverviewIsVisible = false;
                    StatisticsIsVisible = false;
                    InvoiceOverviewIsVisible = false;
                    break;

                case ClientRole.ProjectLead:
                    WeekOverviewIsVisible = true;
                    ProjectOverviewIsVisible = true;
                    StatisticsIsVisible = true;
                    InvoiceOverviewIsVisible = false;
                    break;

                case ClientRole.Admin:
                    WeekOverviewIsVisible = true;
                    ProjectOverviewIsVisible = true;
                    StatisticsIsVisible = true;
                    InvoiceOverviewIsVisible = true;
                    break;

                default:
                    WeekOverviewIsVisible = false;
                    ProjectOverviewIsVisible = false;
                    StatisticsIsVisible = false;
                    InvoiceOverviewIsVisible = false;
                    break;
            }
        }

        public override void Load() { }
        public override void OnAppearing() { }
        public override void OnDisappearing() { }
    }
}
