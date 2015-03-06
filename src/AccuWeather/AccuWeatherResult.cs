namespace AccuWeather
{
    /// <summary>
    /// Weather information for a given location 
    /// </summary>
    public class AccuWeatherResult
    {
        /// <summary>
        /// Temperature at location measured in fahrenheit
        /// </summary>
        public double TempFahrenheit { get; set; }

        /// <summary>
        /// Wind speed at location measured in KPH
        /// </summary>
        public double WindKph { get; set; }
    }
}
