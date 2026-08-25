using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.App.Interface
{
    public interface INavigationService
    {
        Task GoToAsync(string route);
        Task GoToAsync(string route, IDictionary<string, object> parameter);
        Task GoBackAsync();
    }
}
