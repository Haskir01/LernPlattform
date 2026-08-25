using LernPlattform.App.Services;
using LernPlattform.App.Views;

namespace LernPlattform.App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(Routes.Lektionen, typeof(LektionenPage));
    }
}
