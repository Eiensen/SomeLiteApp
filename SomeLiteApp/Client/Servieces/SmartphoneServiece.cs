global using SomeLiteApp.Shared;
using System.Net.Http.Json;

namespace SomeLiteApp.Client.Servieces
{
    public class SmartphoneServiece : ISmartphoneServiece
    {
        private readonly HttpClient _http;

        public SmartphoneServiece(HttpClient http)
        {
            _http = http;
        }

        public List<Smartphone> Smartphones { get; set; } = new List<Smartphone>();

        public async Task GetSmartphones()
        {
            Smartphones = await _http.GetFromJsonAsync<List<Smartphone>>("api/Smartphones");
        }
    }
}
