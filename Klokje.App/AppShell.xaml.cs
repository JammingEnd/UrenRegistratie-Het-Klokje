namespace Klokje.App;

public partial class AppShell : Shell
{
    public bool IsWeekOverviewVisible { get; set; } = true;
    public bool IsProjectsOverviewVisible { get; set; } = true;

    public AppShell()
    {
        InitializeComponent();

        var tabBar = this.Items.OfType<TabBar>().FirstOrDefault();
        if (tabBar != null)
        {
            if (!IsWeekOverviewVisible)
            {
                var weekTab = tabBar.Items.FirstOrDefault(item => item.Title == "WeekOverview");
                if (weekTab != null)
                    tabBar.Items.Remove(weekTab);
            }

            if (!IsProjectsOverviewVisible)
            {
                var projectsTab = tabBar.Items.FirstOrDefault(item => item.Title == "ProjectsOverview");
                if (projectsTab != null)
                    tabBar.Items.Remove(projectsTab);
            }
        }
    }
}