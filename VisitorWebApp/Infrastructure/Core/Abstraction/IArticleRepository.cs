namespace VisitorWebApp.Infrastructure.Core.Abstraction
{
    public interface IArticleRepository
    {
        IEnumerable<IArticle> GetAll();
        IArticle GetArticleById(int id);
        void AddArticle(IArticle article);
        void UpdateArticle(IArticle article);
        void DeleteArticle(int id);
    }
}
