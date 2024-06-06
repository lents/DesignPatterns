namespace StrategyWebApp.Infrastructure.Service
{
    public class SecondTrainingRecommendationStrategy : ITrainingRecommendationStrategy
    {
        public WeatherTypeEnum WeatherType => WeatherTypeEnum.Cold;

        public string GetRecommendationForTraining()
        {
            var result = $"Highly recommend you INDOOR training";
            return result;
        }
    }
}
