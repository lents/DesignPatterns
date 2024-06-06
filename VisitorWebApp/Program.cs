using VisitorWebApp.Infrastructure.Core;
using VisitorWebApp.Infrastructure.Core.Abstraction;
using VisitorWebApp.Infrastructure.DataAccess.DbContext;
using VisitorWebApp.Infrastructure.DataAccess.Repository;
using VisitorWebApp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IDataContext<IArticle>, ArticleDbContext>();

builder.Services.AddScoped<IArticleRepository,ArticleRepository>();

builder.Services.AddScoped<IArticleVisitor, ContentAnalyzerVisitor>();

builder.Services.AddScoped<IArticleService, ArticleService>();




var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
