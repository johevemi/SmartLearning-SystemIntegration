using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public float? TemperatureC { get; set; }

        public float? CloudCover { get; set; }

        public DateTime Sunrise { get; set; }

        public DateTime Sunset { get; set; }

        public float? Visibility { get; set; }

        public string? Condition { get; set; }
    }

    public class ForecastServiceCall
    {
        static HttpClient client = new HttpClient();
        public async Task<List<WeatherForecast>> GetAsync(string path, string password)
        {
            List<WeatherForecast> list = new List<WeatherForecast>();
            client.DefaultRequestHeaders.Add("password", password);
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                list.AddRange(JsonConvert.DeserializeObject<List<WeatherForecast>>(json));
            }
            return list;
        }
    }
}
