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
    public class GuardianConfiguration : IEntityTypeConfiguration<Guardian>
    {
        public void Configure(EntityTypeBuilder<Guardian> builder)
        {
            // Primary Key
            builder.HasKey(g => g.Id);

            // Properties
            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.SecondName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.ThirdName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.ForthName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(g => g.EmailAddress)
                .HasMaxLength(100);

            builder.Property(g => g.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Guardian -> StudentGuardians (One-to-Many)
            builder.HasMany(g => g.StudentGuardians)
                .WithOne(sg => sg.Guardian)
                .HasForeignKey(gt => gt.GuardianId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
