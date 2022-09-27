namespace OnlineShop.WebApi;

public static class ConfigureServices
{
    public const string CorsPolicy = "CorsPolicy";

    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(o => o.AddPolicy(CorsPolicy,
            builder =>
            {
                builder.WithOrigins("http://localhost:5100", "http://localhost:44464")
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

        return services;
    }
}

