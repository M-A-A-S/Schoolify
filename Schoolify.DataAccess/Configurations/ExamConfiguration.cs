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
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        // Properties
        builder.Property(t => t.SubjectClassId)
                .IsRequired();

            builder.Property(t => t.NameEn)
                .IsRequired();

            builder.Property(t => t.NameAr)
                .IsRequired();

            builder.Property(t => t.MaxScore)
                .IsRequired();

            builder.Property(t => t.Date)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Exam -> SubjectClass (Many-to-One)
            builder.HasOne(t => t.SubjectClass)
                .WithMany(sy => sy.Exams)
                .HasForeignKey(t => t.SubjectClassId)
                .OnDelete(DeleteBehavior.Restrict);

            // Exam -> StudentExamResults (One-to-Many)
            builder.HasMany(t => t.StudentExamResults)
                .WithOne(c => c.Exam)
                .HasForeignKey(c => c.ExamId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
