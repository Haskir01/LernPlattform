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
        public ApiService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<BereichDto>> GetBereicheAsync()
        {
            var bereiche = await _http.GetFromJsonAsync<List<BereichDto>>("api/bereiche");
            return bereiche ?? new List<BereichDto>();
        }
    }
}
