using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Infrastructure.Persistance.MongoDb;

namespace OnlineShop.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        MongoDbOptions mongoDbOptions = new MongoDbOptions();
        configuration.GetSection("MongoDb").Bind(mongoDbOptions);
        services.AddSingleton(mongoDbOptions);

        services.AddSingleton<MongoDbContext>();
        services.AddScoped(typeof(IReadRepository<>), typeof(MongoDbReadRepository<>));
        services.AddScoped(typeof(IRepository<>), typeof(MongoDbRepository<>));

        return services;
    }
}
