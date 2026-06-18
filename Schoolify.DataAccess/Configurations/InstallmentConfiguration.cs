using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Configurations
{
    public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
    {
        public void Configure(EntityTypeBuilder<Installment> builder)
        {

        // Primary Key
        builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.EnrollmentId)
                .IsRequired();

            builder.Property(t => t.InstallmentNumber)
                .IsRequired();

            builder.Property(t => t.Amount)
                .IsRequired();

            builder.Property(t => t.DueDate)
                .IsRequired();

            builder.Property(t => t.Status)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships


        }
    }
}
