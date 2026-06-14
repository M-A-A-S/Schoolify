using Schoolify.Common.DTOs.StudentYearLevel;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class StudentYearLevelExtensions
    {
        public static StudentYearLevelDTO ToDTO(this StudentYearLevel entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentYearLevelDTO
            {
                Id = entity.Id,
                StudentId = entity.StudentId,
                YearLevelId = entity.YearLevelId,
                SchoolYearId = entity.SchoolYearId,
                FinalYearScore = entity.FinalYearScore,
            };
        }

        public static StudentYearLevel ToEntity(this StudentYearLevelDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new StudentYearLevel
            {
                Id = DTO.Id,
                StudentId = DTO.StudentId,
                YearLevelId = DTO.YearLevelId,
                SchoolYearId = DTO.SchoolYearId,
                FinalYearScore = DTO.FinalYearScore,
            };
        }

        public static void UpdateFromDTO(this StudentYearLevel entity, StudentYearLevelDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.StudentId = DTO.StudentId;
            entity.YearLevelId = DTO.YearLevelId;
            entity.SchoolYearId = DTO.SchoolYearId;
            entity.FinalYearScore = DTO.FinalYearScore;
        }
    
    }
}
