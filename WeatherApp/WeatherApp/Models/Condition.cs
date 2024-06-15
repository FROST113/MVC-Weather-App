namespace WeatherApp.Models
{
    /// <summary>
    /// Represents the weather condition details.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Gets or sets the condition text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the condition icon URL.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the condition code.
        /// </summary>
        public int Code { get; set; }
    }
}
