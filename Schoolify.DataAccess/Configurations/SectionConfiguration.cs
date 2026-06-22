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
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);


        // Properties
        builder.Property(t => t.YearLevelId)
                .IsRequired();

            builder.Property(t => t.NameEn)
                .IsRequired();

            builder.Property(t => t.NameAr)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Section -> Enrollments (One-to-Many)
            builder.HasMany(t => t.Enrollments)
                .WithOne(c => c.Section)
                .HasForeignKey(c => c.SectionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Section -> SubjectClasses (One-to-Many)
            //builder.HasMany(t => t.SubjectClasses)
            //    .WithOne(c => c.Section)
            //    .HasForeignKey(c => c.SectionId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
