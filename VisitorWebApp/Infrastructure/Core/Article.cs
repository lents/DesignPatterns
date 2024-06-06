using VisitorWebApp.Infrastructure.Core.Abstraction;

namespace VisitorWebApp.Infrastructure.Core
{
    public class Article : IArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int WordCount { get ; set ; }
        public bool HasKeywords { get; set; }

        public void Archive()
        {
            throw new NotImplementedException();
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}
