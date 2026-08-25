using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LernPlattform.App.Interface;
using LernPlattform.App.Services;
using LernPlattform.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LernPlattform.App.ViewModels
{
    public partial class BereicheViewModel:ObservableObject
    {
        private readonly IApiService _api;
        private readonly INavigationService _navigation;

        [ObservableProperty]
        private bool _istAmLaden;

        [ObservableProperty]
        private string? _fehlerText;

        public ObservableCollection<BereichDto> Bereiche { get; } = new();

        public BereicheViewModel(IApiService api, INavigationService navigation)
        {
            _api = api;
            _navigation = navigation;
        }

        [RelayCommand]
        private async Task LadenAsync()
        {
            IstAmLaden = true;
            FehlerText = null;

            try
            {
                var daten = await _api.GetBereicheAsync();

                Bereiche.Clear();
                foreach (var b in daten)
                {
                    Bereiche.Add(b);
                }
            }
            catch (Exception ex)
            {
                FehlerText = $"Fehler beim Laden: {ex.Message}";
            }
            finally
            {
                IstAmLaden = false;
            }
        }
        [RelayCommand]
        private async Task KachelGetippt(BereichDto bereich)
        {
            if (bereich is null)
                return;

            await _navigation.GoToAsync(Routes.Lektionen);
        }
    }
}
