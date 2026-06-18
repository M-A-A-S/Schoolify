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
    public class FeeItemConfiguration : IEntityTypeConfiguration<FeeItem>
    {
        public void Configure(EntityTypeBuilder<FeeItem> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        // Properties
        builder.Property(t => t.FeeStructureId)
                .IsRequired();

            builder.Property(t => t.NameEn)
                .IsRequired();

            builder.Property(t => t.NameAr)
                .IsRequired();

            builder.Property(t => t.Amount)
                .IsRequired();

            builder.Property(t => t.FeeStructureId)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

        }
    }
}
