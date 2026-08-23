using LernPlattform.App.Interface;
using LernPlattform.App.Services;
using LernPlattform.App.ViewModels;
using LernPlattform.App.Views;
using Microsoft.Extensions.Logging;

namespace LernPlattform.App;

public static class MauiProgram
{
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
		builder.Services.AddSingleton(sp => new HttpClient
		{
			BaseAddress = new Uri("http://localhost:5212/")
		});
        builder.Services.AddSingleton<IApiService, ApiService>();
        builder.Services.AddTransient<BereicheViewModel>();
        builder.Services.AddTransient<BereichePage>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
