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
    public class YearLevelConfiguration : IEntityTypeConfiguration<YearLevel>
    {
        public void Configure(EntityTypeBuilder<YearLevel> builder)
        {
            // Primary Key
            builder.HasKey(y => y.Id);

            // Properties
            builder.Property(y => y.NameEn)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(y => y.NameAr)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar(100)");

            builder.Property(y => y.LevelOrder)
                .IsRequired();

            builder.Property("CreatedAt")
              .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // YearLevel -> StudentYearLevels (One-to-Many)
            builder.HasMany(s => s.StudentYearLevels)
                .WithOne(y => y.YearLevel)
                .HasForeignKey(y => y.YearLevelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
