using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Primary Key
            builder.HasKey(s => s.Id);

            // Properties
            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.SecondName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.ThirdName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.ForthName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.Gender)
                .IsRequired();

            builder.Property(s => s.DateOfBirth)
                .IsRequired();

            builder.Property(s => s.EnrolmentDate)
                .IsRequired();

            builder.Property(s => s.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(s => s.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Student -> StudentGuardians (One-to-Many)
            builder.HasMany(s => s.StudentGuardians)
                .WithOne(sg => sg.Student)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Student -> StudentClasses (One-to-Many)
            builder.HasMany(s => s.StudentClasses)
                .WithOne(sc => sc.Student)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Student -> Enrollments (One-to-Many)
            builder.HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
