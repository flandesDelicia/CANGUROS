using Api.Canguros.Filters;

namespace Api.Canguros
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddControllers(option =>
            option.Filters.Add<ApiExceptionFilter>());


            return services;
        }
    }
}
