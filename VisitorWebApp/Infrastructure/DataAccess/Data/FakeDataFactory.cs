using VisitorWebApp.Infrastructure.Core;

namespace VisitorWebApp.Infrastructure.DataAccess.Data
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Article> Articles => new List<Article>()
        {
            new Article()
            {
                Id = 1,
                Title = "Implementing the Visitor Pattern in ASP.NET Core Web API",
                Content = "In an ASP.NET Core Web API employing a 3-tier architecture, the Visitor Pattern is utilized for efficient data manipulation in the C# Article model. The model, CSharpArticle, includes essential properties. The architecture involves a Data Access Layer with a repository managing database interactions, a Business Layer housing the Visitor interface and Article Service, and a Presentation Layer containing the API controllers. The Visitor Pattern is employed in the Business Layer to perform operations on articles, allowing for clean separation of concerns and enabling reusable, structured, and scalable code. This design ensures that CRUD operations benefit from the Visitor Pattern's flexibility while maintaining a clear division of responsibilities across the layers of the application."
            },
            new Article()
            {
                Id = 2,
                Title = "Clean Architecture and Command Pattern ",
                Content = "Implementing the Command Pattern in an ASP.NET Core Web API with Clean Architecture involves creating layers for different concerns like Application, Domain, and Infrastructure. Below is a basic outline to guide you through the process. Note that this is a simplified example, and you may need to adjust it based on your specific requirements."
            },
        };
    }
}
