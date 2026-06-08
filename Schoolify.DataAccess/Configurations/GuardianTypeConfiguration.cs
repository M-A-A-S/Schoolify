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
    public class GuardianTypeConfiguration : IEntityTypeConfiguration<GuardianType>
    {
        public void Configure(EntityTypeBuilder<GuardianType> builder)
        {
            // Primary Key
            builder.HasKey(g => g.Id);

            // Properties
            builder.Property(g => g.NameEn)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(g => g.NameAr)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // GuardianType -> StudentGuardians (One-to-Many)
            builder.HasMany(g => g.StudentGuardians)
                .WithOne(sg => sg.GuardianType)
                .HasForeignKey(gt => gt.GuardianTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
