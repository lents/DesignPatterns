using StrategyWebApp.Infrastructure.Core.Abstraction;
using StrategyWebApp.Infrastructure.Service;

namespace StrategyWebApp.Infrastructure.Core
{
    public class WeatherForecast : IWeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public WeatherTypeEnum WeatherType { get ; set ; }
    }
}