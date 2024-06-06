using StrategyWebApp.Infrastructure.Core;
using StrategyWebApp.Infrastructure.Core.Abstraction;

namespace StrategyWebApp.Infrastructure.DataAccess.Data
{
    public class FakeDataFactory
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static IEnumerable<IWeatherForecast> WeatherForecast => Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]

        });


    }
}
