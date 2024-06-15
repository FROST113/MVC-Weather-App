using WeatherApp.ViewModels;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public interface IWeatherService
    {
        Task<WeatherViewModel> GetWeatherAsync(string location, string unit);
    }
}
