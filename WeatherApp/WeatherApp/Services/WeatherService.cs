using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;
        private readonly WeatherApiSettings _settings;

        public WeatherService(HttpClient client, IOptions<WeatherApiSettings> settings)
        {
            _client = client;
            _client.BaseAddress = new Uri(settings.Value.BaseUrl);
            _settings = settings.Value;
        }

        public async Task<WeatherViewModel> GetWeatherAsync(string location, string unit)
        {
            var response = await _client.GetAsync($"v1/current.json?key={_settings.ApiKey}&q={location}&aqi=no");
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseData);

            return new WeatherViewModel
            {
                Location = $"{weatherData.Location.Name}, {weatherData.Location.Country}",
                Temperature = unit == "C" ? $"{weatherData.Current.Temp_c} °C" : $"{weatherData.Current.Temp_f} °F",
                Condition = weatherData.Current.Condition.Text,
                IconUrl = $"https:{weatherData.Current.Condition.Icon}",
                WindSpeed = $"{weatherData.Current.Wind_kph} kph",
                Humidity = $"{weatherData.Current.Humidity}%",
                Pressure = $"{weatherData.Current.Pressure_mb} mb",
                Visibility = $"{weatherData.Current.Vis_km} km",
                UVIndex = $"{weatherData.Current.Uv}",
                CloudCover = $"{weatherData.Current.Cloud}%"
            };
        }
    }
}
