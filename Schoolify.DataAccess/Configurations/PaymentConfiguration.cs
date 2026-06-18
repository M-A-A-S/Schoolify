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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        // Properties
        builder.Property(t => t.InstallmentId)
                .IsRequired();

            builder.Property(t => t.AmountPaid)
                .IsRequired();

            builder.Property(t => t.PaymentDate)
                .IsRequired();

            builder.Property(t => t.PaymentMethod)
                .IsRequired();

            builder.Property(t => t.ReceiptNumber)
                .IsRequired(false);

            builder.Property(t => t.TransactionReference)
                .IsRequired(false);

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // Installment -> Payments (One-to-Many)
            builder.HasOne(t => t.Installment)
                .WithMany(sy => sy.Payments)
                .HasForeignKey(t => t.InstallmentId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
