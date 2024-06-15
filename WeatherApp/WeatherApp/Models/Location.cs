namespace WeatherApp.Models
{
    /// <summary>
    /// Represents the location details for weather data.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the region of the location.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the country of the location.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the location.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the location.
        /// </summary>
        public double Lon { get; set; }

        /// <summary>
        /// Gets or sets the time zone identifier of the location.
        /// </summary>
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the local time epoch of the location.
        /// </summary>
        public long LocalTimeEpoch { get; set; }

        /// <summary>
        /// Gets or sets the local time of the location.
        /// </summary>
        public string LocalTime { get; set; }
    }
}
