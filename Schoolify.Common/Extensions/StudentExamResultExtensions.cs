using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class StudentExamResultExtensions
    {
        public static StudentExamResultDTO ToDTO(this StudentExamResult entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentExamResultDTO
            {
                Id = entity.Id,
                ExamId = entity.ExamId,
                StudentId = entity.StudentId,
                MarksObtained = entity.MarksObtained,
                Exam = entity.Exam?.ToDTO(),
                Student = entity.Student?.ToDTO()
            };
        }

        public static StudentExamResult ToEntity(this StudentExamResultDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new StudentExamResult
            {
                Id = DTO.Id,
                ExamId = DTO.ExamId,
                StudentId = DTO.StudentId,
                MarksObtained = DTO.MarksObtained,
            };
        }

        public static void UpdateFromDTO(this StudentExamResult entity, StudentExamResultDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.ExamId = DTO.ExamId;
            entity.StudentId = DTO.StudentId;
            entity.MarksObtained = DTO.MarksObtained;
        }

    }
}
