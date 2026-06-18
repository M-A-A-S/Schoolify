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
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            // Primary Key
            builder.HasKey(sy => sy.Id);

            // Properties
            //builder.Property(sy => sy.FinalYearScore)
            //    .HasColumnType("decimal(5,2)");

            builder.Property(syl => syl.StudentId)
                .IsRequired();

            builder.Property(syl => syl.YearLevelId)
                .IsRequired();

            builder.Property(syl => syl.SchoolYearId)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");


            // Relationships

            // Enrollments -> Student (Many-to-One)
            builder.HasOne(sy => sy.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(sy => sy.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Enrollments -> YearLevel (Many-to-One)
            builder.HasOne(sy => sy.YearLevel)
                .WithMany(yl => yl.Enrollments)
                .HasForeignKey(sy => sy.YearLevelId)
                .OnDelete(DeleteBehavior.Restrict);

            // Enrollments -> SchoolYear (Many-to-One)
            builder.HasOne(sy => sy.SchoolYear)
                .WithMany(sy => sy.Enrollments)
                .HasForeignKey(sy => sy.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // Constraints

            //builder.HasCheckConstraint(
            //    "CK_StudentYearLevel_Score",
            //    "[FinalYearScore] IS NULL OR ([FinalYearScore] >= 0 AND [FinalYearScore] <= 100)"
            //);

            // Prevent duplicate enrollment per year
            builder.HasIndex(sy => new
            {
                sy.StudentId,
                sy.YearLevelId,
                sy.SchoolYearId,
                sy.SectionId
            })
            .IsUnique();

        }
    }
}
