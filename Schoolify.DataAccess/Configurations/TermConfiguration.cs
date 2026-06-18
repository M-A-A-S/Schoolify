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
    public class TermConfiguration : IEntityTypeConfiguration<Term>
    {
        public void Configure(EntityTypeBuilder<Term> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.TermNumber)
                .IsRequired();

            builder.Property(t => t.StartDate)
                .IsRequired();

            builder.Property(t => t.EndDate)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Term -> SchoolYear (Many-to-One)
            builder.HasOne(t => t.SchoolYear)
                .WithMany(sy => sy.Terms)
                .HasForeignKey(t => t.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // Term -> SubjectClasses (One-to-Many)
            builder.HasMany(t => t.SubjectClasses)
                .WithOne(c => c.Term)
                .HasForeignKey(c => c.TermId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
