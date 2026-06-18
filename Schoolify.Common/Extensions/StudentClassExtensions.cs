using Schoolify.Common.DTOs.StudentClass;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class StudentClassExtensions
    {
        public static StudentClassDTO ToDTO(this StudentClass entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentClassDTO
            {
                Id = entity.Id,
                SubjectClassId = entity.SubjectClassId,
                StudentId = entity.StudentId,
                FinalScore = entity.FinalScore,
            };
        }

        public static StudentClass ToEntity(this StudentClassDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new StudentClass
            {
                Id = DTO.Id,
                SubjectClassId = DTO.SubjectClassId,
                StudentId = DTO.StudentId,
                FinalScore = DTO.FinalScore,
            };
        }

        public static void UpdateFromDTO(this StudentClass entity, StudentClassDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SubjectClassId = DTO.SubjectClassId;
            entity.StudentId = DTO.StudentId;
            entity.FinalScore = DTO.FinalScore;
        }
   
    }
}
