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
    public partial class KursViewModel : ObservableObject
    {
        private readonly IApiService _api;
        private readonly INavigationService _navigation;

        [ObservableProperty]
        private bool _istAmLaden;

        [ObservableProperty]
        private string? _fehlerText;

        public ObservableCollection<KursDto> Kurse { get; } = new();

        public KursViewModel(IApiService api, INavigationService navigation)
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
                var daten = await _api.GetKursAsync();

                Kurse.Clear();
                foreach (var kurs in daten)
                    Kurse.Add(kurs);
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
        private async Task KachelGetippt(KursDto kurs)
        {
            if (kurs is null)
                return;

            await _navigation.GoToAsync(Routes.Bereiche);
        }
    }
}