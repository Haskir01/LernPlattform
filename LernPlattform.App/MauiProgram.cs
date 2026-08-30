using LernPlattform.App.Interface;
using LernPlattform.App.Services;
using LernPlattform.App.ViewModels;
using LernPlattform.App.Views;
using Microsoft.Extensions.Logging;

namespace LernPlattform.App;

public static class MauiProgram
{
		// Baut und konfiguriert die MAUI-Anwendung: registriert Services, Views und Fonts.
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
		builder.Services.RegisterServices().RegisterViewModels().RegisterViews();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
