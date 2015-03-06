using System;

namespace BbcWeather
{
    /// <summary>
    /// Weather information for a given location 
    /// </summary>
    public class BbcWeatherResult
    {
        /// <summary>
        /// Temperature at location measured in celsius
        /// </summary>
        public double TempCelsius { get; set; }

        /// <summary>
        /// Wind speed at location measured in MPH
        /// </summary>
        public double WindMph { get; set; }

        /// <summary>
        /// DateTime when the measurement was taken
        /// </summary>
        public DateTime Taken { get; set; }
    }
}
