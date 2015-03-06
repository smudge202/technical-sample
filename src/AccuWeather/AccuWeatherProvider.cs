using System;

namespace AccuWeather
{
    public sealed class AccuWeatherProvider
    {
        internal Random _random;

        public AccuWeatherProvider()
        {
            _random = new Random();
        }

        public AccuWeatherResult GetWeatherFor(string location)
        {
            return new AccuWeatherResult
            {
                TempFahrenheit = _random.Next(30, 95),
                WindKph = _random.Next(2, 16)
            };
        }
    }
}
