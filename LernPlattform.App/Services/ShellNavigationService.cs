using LernPlattform.App.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.App.Services
{
    public class ShellNavigationService : INavigationService
    {
        // Navigiert eine Seite zurück in der Shell.
        public Task GoBackAsync() => Shell.Current.GoToAsync("..");




        // Navigiert zu einer Route ohne Parameter.
        public Task GoToAsync(string route) => Shell.Current.GoToAsync(route);
        

        // Navigiert zu einer Route und übergibt Parameter an die Zielseite.
        public Task GoToAsync(string route, IDictionary<string, object> parameter)
            =>Shell.Current.GoToAsync(route, parameter);
     
    }
}
