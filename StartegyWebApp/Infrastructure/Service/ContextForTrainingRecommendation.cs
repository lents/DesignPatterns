namespace StrategyWebApp.Infrastructure.Service
{
    public class ContextForTrainingRecommendation : IContextForTrainingRecommendation
    {
        private readonly Dictionary<WeatherTypeEnum, ITrainingRecommendationStrategy> ChooseTrainingRecommendationStrategy=new Dictionary<WeatherTypeEnum, ITrainingRecommendationStrategy>();
        public IParamsForTrainingRecommendation ParamsForTrainingRecommendation { get ; set; }
        public ITrainingRecommendationStrategy CurrentTrainingRecommendationStrategy { get ; set; }

        public ContextForTrainingRecommendation(IEnumerable<ITrainingRecommendationStrategy> trainingRecommendationStrategies)
        {
            foreach (var strategy in trainingRecommendationStrategies)
            {
                ChooseTrainingRecommendationStrategy.Add(strategy.WeatherType, strategy);
            }
        }

        public void SetStrategy()
        {
            CurrentTrainingRecommendationStrategy = ChooseTrainingRecommendationStrategy[ParamsForTrainingRecommendation.WeatherType];
        }

        public string GetRecommendation()
        {
            return CurrentTrainingRecommendationStrategy.GetRecommendationForTraining();
        }
    }
}
