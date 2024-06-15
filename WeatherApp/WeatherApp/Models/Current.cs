namespace WeatherApp.Models
{
    /// <summary>
    /// Represents the current weather conditions.
    /// </summary>
    public class Current
    {
        /// <summary>
        /// Gets or sets the epoch time of the last update.
        /// </summary>
        public long Last_updated_epoch { get; set; }

        /// <summary>
        /// Gets or sets the last updated time.
        /// </summary>
        public string Last_updated { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Celsius.
        /// </summary>
        public double Temp_c { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Fahrenheit.
        /// </summary>
        public double Temp_f { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is day (1) or night (0).
        /// </summary>
        public int Is_day { get; set; }

        /// <summary>
        /// Gets or sets the weather condition details.
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Gets or sets the wind speed in miles per hour.
        /// </summary>
        public double Wind_mph { get; set; }

        /// <summary>
        /// Gets or sets the wind speed in kilometers per hour.
        /// </summary>
        public double Wind_kph { get; set; }

        /// <summary>
        /// Gets or sets the wind degree.
        /// </summary>
        public int Wind_degree { get; set; }

        /// <summary>
        /// Gets or sets the wind direction.
        /// </summary>
        public string Wind_dir { get; set; }

        /// <summary>
        /// Gets or sets the pressure in millibars.
        /// </summary>
        public double Pressure_mb { get; set; }

        /// <summary>
        /// Gets or sets the pressure in inches.
        /// </summary>
        public double Pressure_in { get; set; }

        /// <summary>
        /// Gets or sets the precipitation in millimeters.
        /// </summary>
        public double Precip_mm { get; set; }

        /// <summary>
        /// Gets or sets the precipitation in inches.
        /// </summary>
        public double Precip_in { get; set; }

        /// <summary>
        /// Gets or sets the humidity percentage.
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover percentage.
        /// </summary>
        public int Cloud { get; set; }

        /// <summary>
        /// Gets or sets the feels-like temperature in Celsius.
        /// </summary>
        public double Feelslike_c { get; set; }

        /// <summary>
        /// Gets or sets the feels-like temperature in Fahrenheit.
        /// </summary>
        public double Feelslike_f { get; set; }

        /// <summary>
        /// Gets or sets the wind chill temperature in Celsius.
        /// </summary>
        public double Windchill_c { get; set; }

        /// <summary>
        /// Gets or sets the wind chill temperature in Fahrenheit.
        /// </summary>
        public double Windchill_f { get; set; }

        /// <summary>
        /// Gets or sets the heat index temperature in Celsius.
        /// </summary>
        public double Heatindex_c { get; set; }

        /// <summary>
        /// Gets or sets the heat index temperature in Fahrenheit.
        /// </summary>
        public double Heatindex_f { get; set; }

        /// <summary>
        /// Gets or sets the dew point temperature in Celsius.
        /// </summary>
        public double Dewpoint_c { get; set; }

        /// <summary>
        /// Gets or sets the dew point temperature in Fahrenheit.
        /// </summary>
        public double Dewpoint_f { get; set; }

        /// <summary>
        /// Gets or sets the visibility in kilometers.
        /// </summary>
        public double Vis_km { get; set; }

        /// <summary>
        /// Gets or sets the visibility in miles.
        /// </summary>
        public double Vis_miles { get; set; }

        /// <summary>
        /// Gets or sets the UV index.
        /// </summary>
        public double Uv { get; set; }

        /// <summary>
        /// Gets or sets the wind gust speed in miles per hour.
        /// </summary>
        public double Gust_mph { get; set; }

        /// <summary>
        /// Gets or sets the wind gust speed in kilometers per hour.
        /// </summary>
        public double Gust_kph { get; set; }
    }
}
