using VisitorWebApp.Infrastructure.Core.Abstraction;
using VisitorWebApp.Infrastructure.DataAccess.DbContext;

namespace VisitorWebApp.Infrastructure.DataAccess.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly IDataContext<IArticle> _context;

        public ArticleRepository(IDataContext<IArticle> context)
        {
            _context = context;
        }

        public IArticle GetArticleById(int id)
        {
            return _context.GetDataContexts.FirstOrDefault(a => a.Id == id);
        }

        public void AddArticle(IArticle article)
        {
            _context.GetDataContexts.Add(article);
        }

        public void UpdateArticle(IArticle article)
        {
            var updatedItem = _context.GetDataContexts.FirstOrDefault(x => x.Id == article.Id);

            if (updatedItem != null)
            {
                CopyProps(article, updatedItem);

            }
        }

        private void CopyProps(IArticle source, IArticle target)
        {
            foreach (var prop in source.GetType().GetProperties())
            {
                if (prop.Name != "Id" )
                {
                    var value = prop.GetValue(source, null);
                    target.GetType().GetProperties().FirstOrDefault(p => p.Name == prop.Name).SetValue(target, value);
                }
            }
        }

        public void DeleteArticle(int id)
        {
            var article = _context.GetDataContexts.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                _context.GetDataContexts.Remove(article);
            }
        }

        public void Accept(IArticleVisitor visitor, int articleId)
        {
            var article = GetArticleById(articleId);
            visitor.Visit(article);
            UpdateArticle(article);
        }

        public IEnumerable<IArticle> GetAll()
        {
            return _context.GetDataContexts;
        }
    }
}
