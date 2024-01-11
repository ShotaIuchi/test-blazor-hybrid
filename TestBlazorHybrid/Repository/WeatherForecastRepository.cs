using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBlazorHybrid.Model;

namespace TestBlazorHybrid.Repository
{
    public class WeatherForecastRepository
    {
        private static readonly string[] summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy",
            "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetWeatherForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray());
        }
    }
}
