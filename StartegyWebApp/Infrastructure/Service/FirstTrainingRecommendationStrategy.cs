namespace StrategyWebApp.Infrastructure.Service
{
    public class FirstTrainingRecommendationStrategy : ITrainingRecommendationStrategy
    {
        public WeatherTypeEnum WeatherType => WeatherTypeEnum.Warm;

        public string GetRecommendationForTraining()
        {
            var result = $"Highly recommend you OUTDOOR training";
            return result;
        }
    }
}
