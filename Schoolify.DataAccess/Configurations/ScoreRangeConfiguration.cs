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
    public class ScoreRangeConfiguration : IEntityTypeConfiguration<ScoreRange>
    {
        public void Configure(EntityTypeBuilder<ScoreRange> builder)
        {
            // Primary Key
            builder.HasKey(sr => sr.Id);

            // Properties
            builder.Property(sr => sr.MinScore)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(sr => sr.MaxScore)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(sr => sr.Grade)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Constraints

            // Basic safety constraint: Min <= Max
            builder.HasCheckConstraint(
                "CK_ScoreRange_MinMax",
                "[MinScore] <= [MaxScore]"
            );

            // Optional but recommended: valid score range
            builder.HasCheckConstraint(
                "CK_ScoreRange_ValidRange",
                "[MinScore] >= 0 AND [MaxScore] <= 100"
            );


            // Prevent duplicate grade definitions
            builder.HasIndex(sr => sr.Grade)
                .IsUnique();
        }
    }
}
