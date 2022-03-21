using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetNext24Hours()
        {
            var client = new ForecastServiceClient();
            var result = client.GetForecastAsync("Kolding default", "[password]").Result.Body.GetForecastResult;
            var currentConditions = result.location.currentConditions;
            var next24hours = new List<WeatherForecast>();
            next24hours.Add(new WeatherForecast
            {
                Date = currentConditions.datetime,
                TemperatureC = currentConditions.temp,
                CloudCover = currentConditions.cloudcover,
                Visibility = currentConditions.visibility,
                Sunrise = currentConditions.sunrise,
                Sunset = currentConditions.sunset
            });

            for (int i = 0; i < 24; i++)
            {
                var condition = result.location.values[i];
                next24hours.Add(new WeatherForecast
                {
                    Date = condition.datetimeStr,
                    TemperatureC = condition.temp,
                    CloudCover = condition.cloudcover,
                    Visibility = condition.visibility,
                    Sunrise = currentConditions.sunrise,
                    Sunset = currentConditions.sunset
                });
            }  
            return next24hours;
        }
    }
}
