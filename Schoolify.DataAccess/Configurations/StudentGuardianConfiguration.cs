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
    public class StudentGuardianConfiguration : IEntityTypeConfiguration<StudentGuardian>
    {
        public void Configure(EntityTypeBuilder<StudentGuardian> builder)
        {
            // Primary Key
            builder.HasKey(sg => sg.Id);

            // Properties
            builder.Property("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property("UpdatedAt")
                .HasDefaultValueSql("GETUTCDATE()");


            // Relationships

            // StudentGuardian -> Student (Many-to-One)
            builder.HasOne(sg => sg.Student)
                .WithMany(s => s.StudentGuardians)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // StudentGuardian -> Guardian (Many-to-One)
            builder.HasOne(sg => sg.Guardian)
                .WithMany(g => g.StudentGuardians)
                .HasForeignKey(sg => sg.GuardianId)
                .OnDelete(DeleteBehavior.Cascade);

            // Constraints

            // StudentGuardian -> GuardianType (Many-to-One)
            builder.HasOne(sg => sg.GuardianType)
                .WithMany(gt => gt.StudentGuardians)
                .HasForeignKey(sg => sg.GuardianTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Prevent duplicate guardian assignments for same student
            //builder.HasIndex(sg => new
            //{
            //    sg.StudentId,
            //    sg.GuardianId,
            //    sg.GuardianTypeId
            //})
            //.IsUnique();

            builder.HasIndex(sg => new
            {
                sg.StudentId,
                sg.GuardianId,
                //sg.GuardianTypeId
            })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");

        }
    }
}
