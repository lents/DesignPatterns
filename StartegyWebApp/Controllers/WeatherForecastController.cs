using Microsoft.AspNetCore.Mvc;
using StrategyWebApp.Infrastructure.Core;
using StrategyWebApp.Infrastructure.Core.Abstraction;
using StrategyWebApp.Infrastructure.Service;

namespace StartegyWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDataContext<IWeatherForecast> _weatherForecastDataContext;
        private readonly IContextForTrainingRecommendation _contextForTrainingRecommendation;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IDataContext<IWeatherForecast> dataContext,
            IContextForTrainingRecommendation contextForTrainingRecommendation)
        {
            _logger = logger;
            _weatherForecastDataContext = dataContext;
            _contextForTrainingRecommendation = contextForTrainingRecommendation;
        }

        [HttpGet("GetWeatherForecast")]
        public List<IWeatherForecast> Get()
        {
            return _weatherForecastDataContext.GetDataContext;
        }

        [HttpGet("GetTrainingRecommendation")]
        public List<string> GetRecommendation()
        {
            var result=new List<string>();
            foreach(var day in _weatherForecastDataContext.GetDataContext)
            {
                _contextForTrainingRecommendation.ParamsForTrainingRecommendation = new ParamsForTrainingRecommendation() { WeatherType = day.WeatherType };
                _contextForTrainingRecommendation.SetStrategy();
                result.Add($"{day.Date} - {_contextForTrainingRecommendation.GetRecommendation()}");
            }
            return result;
        }
    }
}