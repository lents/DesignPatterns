namespace StrategyWebApp.Infrastructure.Service
{
    public interface IContextForTrainingRecommendation
    {
        IParamsForTrainingRecommendation ParamsForTrainingRecommendation { get; set; }
        ITrainingRecommendationStrategy CurrentTrainingRecommendationStrategy { get; set;  }
        void SetStrategy();
        string GetRecommendation();
    }

}
