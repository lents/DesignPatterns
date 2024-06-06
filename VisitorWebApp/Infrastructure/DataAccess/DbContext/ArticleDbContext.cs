using VisitorWebApp.Infrastructure.Core.Abstraction;
using VisitorWebApp.Infrastructure.DataAccess.Data;

namespace VisitorWebApp.Infrastructure.DataAccess.DbContext
{
    public class ArticleDbContext:IDataContext<IArticle>
    {
        private readonly List<IArticle> _articles;
        public List<IArticle> GetDataContexts => _articles;
        public ArticleDbContext()
        {
            _articles = new List<IArticle>(FakeDataFactory.Articles);
        }
    }
}
