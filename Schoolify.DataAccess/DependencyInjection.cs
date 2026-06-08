using Microsoft.Extensions.DependencyInjection;

namespace Schoolify.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
