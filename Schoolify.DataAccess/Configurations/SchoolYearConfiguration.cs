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
    public class SchoolYearConfiguration : IEntityTypeConfiguration<SchoolYear>
    {
        public void Configure(EntityTypeBuilder<SchoolYear> builder)
        {
            // Primary Key
            builder.HasKey(s => s.Id);

            // Properties
            builder.Property(s => s.NameEn)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(s => s.NameAr)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.StartDate)
                .IsRequired();

            builder.Property(s => s.EndDate)
                .IsRequired();

            builder.Property("CreatedAt")
              .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // SchoolYear -> Terms (One-to-Many)
            builder.HasMany(s => s.Terms)
                .WithOne(t => t.SchoolYear)
                .HasForeignKey(t => t.SchoolYearId)
                .OnDelete(DeleteBehavior.Cascade);

            // SchoolYear -> Periods (One-to-Many)
            builder.HasMany(s => s.Periods)
                .WithOne(p => p.SchoolYear)
                .HasForeignKey(p => p.SchoolYearId)
                .OnDelete(DeleteBehavior.Cascade);

            // SchoolYear -> StudentYearLevels (One-to-Many)
            builder.HasMany(s => s.StudentYearLevels)
                .WithOne(p => p.SchoolYear)
                .HasForeignKey(p => p.SchoolYearId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
