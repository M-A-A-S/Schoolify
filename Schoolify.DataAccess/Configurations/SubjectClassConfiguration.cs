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
    public class SubjectClassConfiguration : IEntityTypeConfiguration<SubjectClass>
    {
        public void Configure(EntityTypeBuilder<SubjectClass> builder)
        {
            // Table name
            builder.ToTable("SubjectClasses");

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

            // SubjectClass -> Subject (One-to-Many)
            builder.HasOne(c => c.Subject)
                .WithMany(s => s.SubjectClasses)
                .HasForeignKey(c => c.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // SubjectClass -> Teacher (Many-to-One)
            builder.HasMany(c => c.SubjectClassTeachers)
                .WithOne(t => t.SubjectClass)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // SubjectClass -> Term (Many-to-One)
            builder.HasOne(c => c.Term)
                .WithMany(t => t.SubjectClasses)
                .HasForeignKey(c => c.TermId)
                .OnDelete(DeleteBehavior.Cascade);

            // SubjectClass -> StudentClasses (One-to-Many)
            builder.HasMany(c => c.StudentClasses)
                .WithOne(sc => sc.SubjectClass)
                .HasForeignKey(sc => sc.SubjectClassId)
                .OnDelete(DeleteBehavior.Cascade);

            // SubjectClass -> Section (Many-to-One)
            //builder.HasOne(x => x.Section)
            //.WithMany(s => s.SubjectClasses)
            //.HasForeignKey(x => x.SectionId)
            //.OnDelete(DeleteBehavior.Restrict);


            builder.HasIndex(x => new
            {
                x.SubjectId,
                //x.TeacherId,
                x.TermId,
                //x.SectionId
            })
            .IsUnique(); // prevents duplicate class offerings

        }
    }
}
