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
                ClassId = entity.ClassId,
                StudentId = entity.StudentId,
                MarksObtained = entity.MarksObtained,
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
                ClassId = DTO.ClassId,
                StudentId = DTO.StudentId,
                MarksObtained = DTO.MarksObtained,
            };
        }

        public static void UpdateFromDTO(this StudentClass entity, StudentClassDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.ClassId = DTO.ClassId;
            entity.StudentId = DTO.StudentId;
            entity.MarksObtained = DTO.MarksObtained;
        }
   
    }
}
