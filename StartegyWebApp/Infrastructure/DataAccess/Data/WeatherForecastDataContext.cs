using StrategyWebApp.Infrastructure.Core.Abstraction;

namespace StrategyWebApp.Infrastructure.DataAccess.Data
{
    public class WeatherForecastDataContext : IDataContext<IWeatherForecast>
    {
        private readonly List<IWeatherForecast> _weatherForecast;
        public List<IWeatherForecast> GetDataContext => _weatherForecast;
        public WeatherForecastDataContext()
        {
            _weatherForecast = new List<IWeatherForecast>(FakeDataFactory.WeatherForecast);
            _weatherForecast.ForEach(item => item.WeatherType = item.TemperatureC < 15 ? Service.WeatherTypeEnum.Cold : Service.WeatherTypeEnum.Warm);
        }
    }
}
