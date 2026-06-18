using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Configurations
{
    public class ClassScheduleConfiguration : IEntityTypeConfiguration<ClassSchedule>
    {
        public void Configure(EntityTypeBuilder<ClassSchedule> builder)
        {
            // Primary Key
            builder.HasKey(cs => cs.Id);

            // Properties
            builder.Property(cs => cs.DayOfWeek)
                .IsRequired();

            builder.Property(cs => cs.SubjectClassTeacherId)
                .IsRequired();

            builder.Property(cs => cs.PeriodId)
                .IsRequired();

            builder.Property(cs => cs.ClassroomId)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // ClassSchedule -> SubjectClassTeacher (Many-to-One)
            builder.HasOne(cs => cs.SubjectClassTeacher)
                .WithMany(c => c.ClassSchedules)
                .HasForeignKey(cs => cs.SubjectClassTeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassSchedule -> Period (Many-to-One)
            builder.HasOne(cs => cs.Period)
                .WithMany(p => p.ClassSchedules)
                .HasForeignKey(cs => cs.PeriodId)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassSchedule -> Classroom (Many-to-One)
            builder.HasOne(cs => cs.Classroom)
                .WithMany(c => c.ClassSchedules)
                .HasForeignKey(cs => cs.ClassroomId)
                .OnDelete(DeleteBehavior.Restrict);

            // Prevent double booking for the same class
            builder.HasIndex(cs => new
            {
                //cs.ClassId,
                cs.SubjectClassTeacherId,
                cs.PeriodId,
                cs.DayOfWeek
            })
            .IsUnique();

            // Prevent classroom being double-booked
            builder.HasIndex(cs => new
            {
                cs.ClassroomId,
                cs.PeriodId,
                cs.DayOfWeek
            })
            .IsUnique();
        }
    }
}
