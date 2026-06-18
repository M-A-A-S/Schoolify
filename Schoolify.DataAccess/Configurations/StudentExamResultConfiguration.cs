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
    public class StudentExamResultConfiguration : IEntityTypeConfiguration<StudentExamResult>
    {
        public void Configure(EntityTypeBuilder<StudentExamResult> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.ExamId)
                .IsRequired();

            builder.Property(t => t.StudentId)
                .IsRequired();

            builder.Property(t => t.MarksObtained)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Exam -> SubjectClasses (Many-to-One)
            builder.HasOne(t => t.Exam)
                .WithMany(sy => sy.StudentExamResults)
                .HasForeignKey(t => t.ExamId)
                .OnDelete(DeleteBehavior.Restrict);

            // Exam -> Students (One-to-Many)
            builder.HasOne(t => t.Student)
                .WithMany(c => c.StudentExamResults)
                .HasForeignKey(c => c.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
