using LernPlattform.App.Interface;
using LernPlattform.App.Services;
using LernPlattform.App.ViewModels;
using LernPlattform.App.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.App
{
    public static class Startup
    {
        // Adresse der API an einer Stelle
        private static string ApiBaseUrl =>
#if ANDROID
    "http://10.0.2.2:5212/";
#else
    "http://localhost:5212/";
#endif

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl)
            });
            services.AddSingleton<IApiService, ApiService>();
            services.AddSingleton<INavigationService, ShellNavigationService>();
            return services;
        }
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddTransient<BereicheViewModel>();
            services.AddTransient<KursViewModel>();
            return services;
        }
        public static IServiceCollection RegisterViews(this IServiceCollection services)
        {
            services.AddTransient<BereichePage>();
            services.AddTransient<LektionenPage>();
            services.AddTransient<KursPage>();
            return services;
        }
    }
}
