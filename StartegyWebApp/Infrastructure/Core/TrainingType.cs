using StrategyWebApp.Infrastructure.Core.Abstraction;

namespace StrategyWebApp.Infrastructure.Core
{
    public class TrainingType : ITrainingType
    {
        public int Id { get ; set ; }
        public string Name { get; set; } = "Undefined name";
        public override string ToString()
        {
            return Name;
        }
    }
}
