using VisitorWebApp.Infrastructure.Core.Abstraction;

namespace VisitorWebApp.Infrastructure.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _repository;

        public ArticleService(IArticleRepository repository)
        {
            _repository = repository;
        }

        public void Accept(IArticleVisitor visitor, int articleId)
        {
            IArticle article = _repository.GetArticleById(articleId);
            visitor.Visit(article);
            _repository.UpdateArticle(article);
        }

        public void Publish(int articleId)
        {
            IArticle article = _repository.GetArticleById(articleId);
            article.Publish();
            _repository.UpdateArticle(article);
        }

        public void Archive(int articleId)
        {
            IArticle article = _repository.GetArticleById(articleId);
            article.Archive();
            _repository.UpdateArticle(article);
        }
    }
}
