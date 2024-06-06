namespace VisitorWebApp.Infrastructure.Core.Abstraction
{
    public interface IArticleService
    {
        void Accept(IArticleVisitor visitor, int articleId);
        void Archive(int articleId);
        void Publish(int articleId);
    }
}