using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schoolify.DataAccess;

namespace Schoolify.Business
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessServices(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDataAccess(configuration);

            return services;
        }
    }
}
