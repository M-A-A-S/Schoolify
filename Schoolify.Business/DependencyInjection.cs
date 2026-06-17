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
            services.AddScoped<IScoreRangeService, ScoreRangeService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IGuardianService, GuardianService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGuardianTypeService, GuardianTypeService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISchoolStageService, SchoolStageService>();
            services.AddScoped<ISchoolYearService, SchoolYearService>();
            services.AddScoped<IYearLevelService, YearLevelService>();
            services.AddScoped<ITermService, TermService>();
            services.AddScoped<IPeriodService, PeriodService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IClassroomService, ClassroomService>();
            services.AddScoped<IClassroomTypeService, ClassroomTypeService>();
            services.AddScoped<IClassScheduleService, ClassScheduleService>();

            return services;
        }
    }
}
