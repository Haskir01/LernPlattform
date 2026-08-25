using LernPlattform.App.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.App.Services
{
    public class ShellNavigationService : INavigationService
    {
        public Task GoBackAsync() => Shell.Current.GoToAsync("..");




        public Task GoToAsync(string route) => Shell.Current.GoToAsync(route);
        

        public Task GoToAsync(string route, IDictionary<string, object> parameter)
            =>Shell.Current.GoToAsync(route, parameter);
     
    }
}
