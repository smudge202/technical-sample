using System;

namespace BbcWeather
{
    public sealed class BbcWeatherProvider
    {
        internal Random _random;

        public BbcWeatherProvider()
        {
            _random = new Random();
        }

        public BbcWeatherResult GetWeatherFor(string location)
        {
            return new BbcWeatherResult {
                TempCelsius = _random.Next(-1, 30),
                WindMph = _random.Next(1, 8),
                Taken = DateTime.Now.AddMinutes(-DateTime.Now.Minute)
                };
        }
    }
}
