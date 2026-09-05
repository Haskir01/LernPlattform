using LernPlattform.App.Interface;
using LernPlattform.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace LernPlattform.App.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _http;
        // Konstruktor: Speichert den HttpClient für spätere API-Aufrufe.
        public ApiService(HttpClient http)
        {
            _http = http;
        }

        // Holt die Liste der Bereiche von der API und gibt sie zurück.
        public async Task<List<BereichDto>> GetBereicheAsync()
        {
            var bereiche = await _http.GetFromJsonAsync<List<BereichDto>>("api/bereiche");
            return bereiche ?? new List<BereichDto>();
        }

        public async Task<List<KursDto>> GetKursAsync()
        {
            var kurse = await _http.GetFromJsonAsync<List<KursDto>>("api/kurse");
            return kurse ?? new List<KursDto>();
        }
    }
}
