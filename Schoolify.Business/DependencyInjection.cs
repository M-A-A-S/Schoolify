using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schoolify.Business.Interfaces;
using Schoolify.Business.Services;
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
            services.AddApplicationRepositories();
            services.AddApplicationServices();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IGuardianService, GuardianService>();

            return services;
        }
    }
}
