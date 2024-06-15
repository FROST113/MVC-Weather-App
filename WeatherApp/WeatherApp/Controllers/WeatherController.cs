using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WeatherApp.Services;
using WeatherApp.ViewModels;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
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
                var viewModel = await _weatherService.GetWeatherAsync(location, unit);
                return PartialView("~/Views/WeatherForecast/_WeatherPartialView.cshtml", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the weather data.");
                return BadRequest("An error occurred while fetching the weather data.");
            }
        }
    }
}
