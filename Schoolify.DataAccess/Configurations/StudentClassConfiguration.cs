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
    public class StudentClassConfiguration : IEntityTypeConfiguration<StudentClass>
    {
        public void Configure(EntityTypeBuilder<StudentClass> builder)
        {
            // Primary Key
            builder.HasKey(sc => sc.Id);

            // Properties
            builder.Property(sc => sc.MarksObtained)
                .HasColumnType("decimal(5,2)");

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // StudentClass -> Subject (One-to-Many)
            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentClasses)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // StudentClass -> Class (One-to-Many)
            builder.HasOne(sc => sc.Class)
                .WithMany(c => c.StudentClasses)
                .HasForeignKey(sc => sc.ClassId)
                .OnDelete(DeleteBehavior.Cascade);


            // Constraints

            // Prevent duplicate enrollment
            builder.HasIndex(sc => new { sc.StudentId, sc.ClassId })
                .IsUnique();

            // Safety constraint
            builder.HasCheckConstraint(
                "CK_StudentClass_Marks",
                "[MarksObtained] IS NULL OR ([MarksObtained] >= 0 AND [MarksObtained] <= 100)"
            );
        }
    }
}
