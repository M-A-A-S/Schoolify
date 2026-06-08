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
    public class ClassroomTypeConfiguration : IEntityTypeConfiguration<ClassroomType>
    {
        public void Configure(EntityTypeBuilder<ClassroomType> builder)
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

            builder.Property("CreatedAt")
              .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");


            // Relationships

            // ClassroomType -> Classroom (One-to-Many)
            builder.HasMany(ct => ct.Classrooms)
                .WithOne(c => c.RoomType)
                .HasForeignKey(c => c.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
