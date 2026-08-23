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
        private const string ApiBaseUrl = "http://localhost:5212/";

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl)
            });
            services.AddSingleton<IApiService, ApiService>();
            return services;
        }
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddTransient<BereicheViewModel>();
            return services;
        }
        public static IServiceCollection RegisterViews(this IServiceCollection services)
        {
            services.AddTransient<BereichePage>();
            return services;
        }
    }
}
