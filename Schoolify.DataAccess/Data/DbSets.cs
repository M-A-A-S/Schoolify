using Microsoft.EntityFrameworkCore;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Data
{
    public partial class AppDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassroomType> ClassroomTypes { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<GuardianType> GuardianTypes { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<SchoolStage> SchoolStages { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<ScoreRange> ScoreRanges { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentGuardian> StudentGuardians { get; set; }
        public DbSet<StudentYearLevel> StudentYearLevels { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<YearLevel> YearLevels { get; set; }

    }
}
