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
                TotalMarks = entity.TotalMarks,
                MaxMarks = entity.MaxMarks,
                GradeLetter = entity.GradeLetter,
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
                TotalMarks = DTO.TotalMarks,
                MaxMarks = DTO.MaxMarks,
                GradeLetter = DTO.GradeLetter,
                IsPassed = DTO.IsPassed,
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
            entity.TotalMarks = DTO.TotalMarks;
            entity.MaxMarks = DTO.MaxMarks;
            entity.GradeLetter = DTO.GradeLetter;
            entity.IsPassed = DTO.IsPassed;
            entity.CalculatedAt = DTO.CalculatedAt;
        }

    }
}
