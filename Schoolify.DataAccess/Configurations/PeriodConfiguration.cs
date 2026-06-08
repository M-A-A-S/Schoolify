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
    public class PeriodConfiguration : IEntityTypeConfiguration<Period>
    {
        public void Configure(EntityTypeBuilder<Period> builder)
        {
            // Primary Key
            builder.HasKey(p => p.Id);

            // Properties
            builder.Property(p => p.NameEn)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.NameAr)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.StartTime)
                .IsRequired();

            builder.Property(p => p.EndTime)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Period -> SchoolYear (Many-to-One)
            builder.HasOne(p => p.SchoolYear)
                .WithMany(p => p.Periods)
                .HasForeignKey(p => p.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // Period -> ClassSchedules (One-to-Many)
            builder.HasMany(p => p.ClassSchedules)
                .WithOne(cs => cs.Period)
                .HasForeignKey(cs => cs.PeriodId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
