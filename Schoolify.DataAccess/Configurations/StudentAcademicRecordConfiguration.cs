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
    public class StudentAcademicRecordConfiguration : IEntityTypeConfiguration<StudentAcademicRecord>
    {
        public void Configure(EntityTypeBuilder<StudentAcademicRecord> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        // Properties
        builder.Property(t => t.EnrollmentId)
                .IsRequired();

            builder.Property(t => t.TotalMarks)
                .IsRequired();

            builder.Property(t => t.MaxMarks)
                .IsRequired();

            builder.Property(t => t.GradeLetter)
                .IsRequired();

            builder.Property(t => t.IsPassed)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Enrollment -> StudentAcademicRecord (One-to-One)
            builder.HasOne(t => t.Enrollment)
                .WithOne(x => x.StudentAcademicRecord)
                .HasForeignKey<StudentAcademicRecord>(x => x.EnrollmentId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
