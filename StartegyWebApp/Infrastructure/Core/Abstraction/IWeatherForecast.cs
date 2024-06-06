using StrategyWebApp.Infrastructure.Service;

namespace StrategyWebApp.Infrastructure.Core.Abstraction
{
    public interface IWeatherForecast
    {
        DateOnly Date { get; set; }
        string? Summary { get; set; }
        int TemperatureC { get; set; }
        int TemperatureF { get; }
        WeatherTypeEnum WeatherType { get; set; }
    }
}