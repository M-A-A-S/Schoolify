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
    public class FeeStructureConfiguration : IEntityTypeConfiguration<FeeStructure>
    {
        public void Configure(EntityTypeBuilder<FeeStructure> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        // Properties
            builder.Property(t => t.SchoolYearId)
                .IsRequired();

            builder.Property(t => t.YearLevelId)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // FeeStructure -> SchoolYear (Many-to-One)
            builder.HasOne(t => t.SchoolYear)
                .WithMany(sy => sy.FeeStructures)
                .HasForeignKey(t => t.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // FeeStructure -> YearLevel (Many-to-One)
            builder.HasOne(t => t.YearLevel)
                .WithMany(yl => yl.FeeStructures)
                .HasForeignKey(t => t.YearLevelId)
                .OnDelete(DeleteBehavior.Restrict);

            // FeeStructure -> FeeItems (One-to-Many)
            builder.HasMany(t => t.FeeItems)
                .WithOne(c => c.FeeStructure)
                .HasForeignKey(c => c.FeeStructureId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
