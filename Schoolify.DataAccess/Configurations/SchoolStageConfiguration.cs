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
    public class SchoolStageConfiguration : IEntityTypeConfiguration<SchoolStage>
    {
        public void Configure(EntityTypeBuilder<SchoolStage> builder)
        {
            // Primary Key
            builder.HasKey(s => s.Id);

            // Properties
            builder.Property(s => s.NameEn)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(s => s.NameAr)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar(100)");

            builder.Property("CreatedAt")
              .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // SchoolStage -> YearLevels (One-to-Many)
            builder.HasMany(s => s.YearLevels)
                .WithOne(y => y.SchoolStage)
                .HasForeignKey(y => y.SchoolStageId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
