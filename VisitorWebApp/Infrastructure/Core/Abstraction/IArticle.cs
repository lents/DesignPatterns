namespace VisitorWebApp.Infrastructure.Core.Abstraction
{
    public interface IArticle
    {
        string Content { get; set; }
        int Id { get; set; }
        string Title { get; set; }
        int WordCount { get; set; }
        bool HasKeywords { get; set; }
        void Publish();
        void Archive();
    }
}