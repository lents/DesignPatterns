namespace VisitorWebApp.Infrastructure.Core.Abstraction
{
    public interface IDataContext<T>
    {
        public List<T> GetDataContexts { get; }
    }
}
