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
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
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

            builder.Property(c => c.Capacity)
                .IsRequired();

            builder.Property("CreatedAt")
              .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            // Classroom -> ClassroomType (Many-to-One)
            builder.HasOne(c => c.RoomType)
                .WithMany(rt => rt.Classrooms)
                .HasForeignKey(c => c.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Classroom -> ClassSchedules (One-to-Many)
            builder.HasMany(c => c.ClassSchedules)
                .WithOne(cs => cs.Classroom)
                .HasForeignKey(cs => cs.ClassroomId) 
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
