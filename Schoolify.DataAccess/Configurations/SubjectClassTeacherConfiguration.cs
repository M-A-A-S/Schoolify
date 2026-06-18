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
    public class SubjectClassTeacherConfiguration : IEntityTypeConfiguration<SubjectClassTeacher>
    {
        public void Configure(EntityTypeBuilder<SubjectClassTeacher> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.SubjectClassId)
                .IsRequired();

            builder.Property(t => t.TeacherId)
                .IsRequired();

            builder.Property(t => t.IsMainTeacher)
                .IsRequired();

            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships

            // SubjectClassTeacher -> SubjectClass (Many-to-One)
            builder.HasOne(t => t.SubjectClass)
                .WithMany(sy => sy.SubjectClassTeachers)
                .HasForeignKey(t => t.SubjectClassId)
                .OnDelete(DeleteBehavior.Restrict);

            // SubjectClassTeacher -> Teacher (Many-to-One)
            builder.HasOne(t => t.Teacher)
                .WithMany(sy => sy.SubjectClassTeachers)
                .HasForeignKey(t => t.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
