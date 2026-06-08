using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schoolify.Common;
using Schoolify.DataAccess.Data;

namespace Schoolify.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IServiceCollection AddDataAccess(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                //options.UseSqlServer(AppSettings.ConnectionString));
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
