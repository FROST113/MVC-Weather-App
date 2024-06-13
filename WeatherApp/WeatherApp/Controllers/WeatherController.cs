using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public WeatherController(IConfiguration configuration)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.weatherapi.com/");
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Weather Forecast";
            return View("~/Views/WeatherForecast/WeatherForecast.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string location, string unit)
        {
            try
            {
                string apiKey = _configuration["WeatherApi:ApiKey"];
                var response = await _client.GetAsync($"v1/current.json?key={apiKey}&q={location}&aqi=no");
                response.EnsureSuccessStatusCode();
                var responseData = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseData);

                var viewModel = new WeatherViewModel
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

                return PartialView("~/Views/WeatherForecast/_WeatherPartialView.cshtml", viewModel);
            }
            catch (Exception ex)
            {
                return Content($"An error occurred: {ex.Message}");
            }
        }

    }
}
