namespace WeatherApp.Models
{
    /// <summary>
    /// Represents weather data, including location and current weather conditions.
    /// </summary>
    public class WeatherData
    {
        /// <summary>
        /// Gets or sets the location details.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the current weather conditions.
        /// </summary>
        public Current Current { get; set; }
    }
}
