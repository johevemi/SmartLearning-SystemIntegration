using System;

namespace Forecast
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public float? TemperatureC { get; set; }

        public float? CloudCover { get; set; }

        public DateTime Sunrise { get; set; }

        public DateTime Sunset { get; set; }

        public float? Visibility { get; set; }
    }
}
