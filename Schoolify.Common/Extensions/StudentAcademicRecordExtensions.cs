using Schoolify.Common.DTOs.StudentAcademicRecord;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    
    public static class StudentAcademicRecordExtensions
    {
        public static StudentAcademicRecordDTO ToDTO(this StudentAcademicRecord entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentAcademicRecordDTO
            {
                Id = entity.Id,
                EnrollmentId = entity.EnrollmentId,
                ObtainedMarks = entity.ObtainedMarks,
                MaxMarks = entity.MaxMarks,
                GradeLetter = entity.GradeLetter,
                Percentage = entity.Percentage,
                IsPassed = entity.IsPassed,
                CalculatedAt = entity.CalculatedAt,
                //Enrollment = entity.Enrollment?.ToDTO()
            };
        }

        public static StudentAcademicRecord ToEntity(this StudentAcademicRecordDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new StudentAcademicRecord
            {
                Id = DTO.Id,
                EnrollmentId = DTO.EnrollmentId,
                ObtainedMarks = DTO.ObtainedMarks,
                MaxMarks = DTO.MaxMarks,
                GradeLetter = DTO.GradeLetter,
                IsPassed = DTO.IsPassed,
                Percentage = DTO.Percentage,
                CalculatedAt = DTO.CalculatedAt,
            };
        }

        public static void UpdateFromDTO(this StudentAcademicRecord entity, StudentAcademicRecordDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.EnrollmentId = DTO.EnrollmentId;
            entity.ObtainedMarks = DTO.ObtainedMarks;
            entity.MaxMarks = DTO.MaxMarks;
            entity.GradeLetter = DTO.GradeLetter;
            entity.IsPassed = DTO.IsPassed;
            entity.Percentage = DTO.Percentage;
            entity.CalculatedAt = DTO.CalculatedAt;
        }

    }
}
