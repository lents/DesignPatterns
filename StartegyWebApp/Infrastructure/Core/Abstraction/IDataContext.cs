namespace StrategyWebApp.Infrastructure.Core.Abstraction
{
    public interface IDataContext<T>
    {
        public List<T> GetDataContext { get; }
    }
}
