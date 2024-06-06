using VisitorWebApp.Infrastructure.Core.Abstraction;

namespace VisitorWebApp.Infrastructure.Service
{
    public class ContentAnalyzerVisitor : IArticleVisitor
    {
        public void Visit(IArticle article)
        {
            if (article != null)
            {
                int wordCount = CountWords(article.Content);
                bool hasKeywords = CheckForKeywords(article.Content);

                article.WordCount = wordCount;
                article.HasKeywords = hasKeywords;
            }
        }

        private int CountWords(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return 0;

            string[] words = content.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private bool CheckForKeywords(string content)
        {
            string[] keywordsToCheck = { "C#", "ASP.NET", "Entity Framework" }; //if needed
            foreach (string keyword in keywordsToCheck)
                {
                    if (content.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}
