namespace VisitorWebApp.Infrastructure.Core.Abstraction
{
    public interface IArticleVisitor
    {
        void Visit(IArticle article);
    }
}
