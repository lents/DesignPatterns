
using StrategyWebApp.Infrastructure.Core.Abstraction;
using StrategyWebApp.Infrastructure.DataAccess.Data;
using StrategyWebApp.Infrastructure.Service;

namespace StartegyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IDataContext<IWeatherForecast>,WeatherForecastDataContext > ();
            builder.Services.AddTransient<ITrainingRecommendationStrategy, FirstTrainingRecommendationStrategy>();
            builder.Services.AddTransient<ITrainingRecommendationStrategy, SecondTrainingRecommendationStrategy>();
            builder.Services.AddTransient<IContextForTrainingRecommendation, ContextForTrainingRecommendation>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}