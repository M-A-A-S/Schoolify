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

            services.AddScoped<IStudentAcademicRecordRepository, StudentAcademicRecordRepository>();
            services.AddScoped<IStudentClassRepository, StudentClassRepository>();
            services.AddScoped<IStudentExamResultRepository, StudentExamResultRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IInstallmentRepository, InstallmentRepository>();
            services.AddScoped<IFeeItemRepository, FeeItemRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IFeeStructureRepository, FeeStructureRepository>();
            services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
            services.AddScoped<ISubjectClassTeacherRepository, SubjectClassTeacherRepository>();
            services.AddScoped<IScoreRangeRepository, ScoreRangeRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IGuardianRepository, GuardianRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IGuardianTypeRepository, GuardianTypeRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ISchoolStageRepository, SchoolStageRepository>();
            services.AddScoped<ISchoolYearRepository, SchoolYearRepository>();
            services.AddScoped<IYearLevelRepository, YearLevelRepository>();
            services.AddScoped<ITermRepository, TermRepository>();
            services.AddScoped<IPeriodRepository, PeriodRepository>();
            services.AddScoped<ISubjectClassRepository, SubjectClassRepository>();
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<IClassroomTypeRepository, ClassroomTypeRepository>();
            services.AddScoped<IClassScheduleRepository, ClassScheduleRepository>();

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
