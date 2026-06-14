using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schoolify.Common;
using Schoolify.DataAccess.Data;
using Schoolify.DataAccess.Interfaces;
using Schoolify.DataAccess.Repositories;

namespace Schoolify.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {

            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IGuardianRepository, GuardianRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IGuardianTypeRepository, GuardianTypeRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ISchoolStageRepository, SchoolStageRepository>();

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
