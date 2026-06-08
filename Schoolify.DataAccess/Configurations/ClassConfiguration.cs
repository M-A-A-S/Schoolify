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
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties
            builder.Property(c => c.NameEn)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(c => c.NameAr)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar(100)");

            builder.Property(c => c.MaxScore)
                .IsRequired()
                .HasColumnType("decimal(5,2)")
                .HasDefaultValue(100.00);



            // Relationships

            // Class -> Subject (One-to-Many)
            builder.HasOne(c => c.Subject)
                .WithMany()
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // Class -> Teacher (Many-to-One)
            builder.HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Class -> Term (Many-to-One)
            builder.HasOne(c => c.Term)
                .WithMany(t => t.Classes)
                .HasForeignKey(c => c.TermId)
                .OnDelete(DeleteBehavior.Cascade);

            // Class -> StudentClasses (One-to-Many)
            builder.HasMany(c => c.StudentClasses)
                .WithOne()
                .HasForeignKey(sc => sc.ClassId) 
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
