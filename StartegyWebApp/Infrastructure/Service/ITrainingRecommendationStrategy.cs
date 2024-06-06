namespace StrategyWebApp.Infrastructure.Service
{
    public interface ITrainingRecommendationStrategy
    {
        public WeatherTypeEnum WeatherType { get; }    
        public string GetRecommendationForTraining();
    }
}
