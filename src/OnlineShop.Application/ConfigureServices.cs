using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineShop.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();

        services.AddMediatR(executingAssembly);
        services.AddAutoMapper(executingAssembly);

        return services;
    }
}
