using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class EnrollmentExtensions
    {
        public static EnrollmentDTO ToDTO(this Enrollment entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new EnrollmentDTO
            {
                Id = entity.Id,
                StudentId = entity.StudentId,
                YearLevelId = entity.YearLevelId,
                SchoolYearId = entity.SchoolYearId,
                

                Section = entity?.Section.ToDTO(),
                Student = entity?.Student?.ToDTO(),
                SchoolYear = entity?.SchoolYear?.ToDTO(),
                YearLevel = entity?.YearLevel?.ToDTO(),
            };
        }

        public static Enrollment ToEntity(this EnrollmentDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Enrollment
            {
                Id = DTO.Id,
                StudentId = DTO.StudentId,
                YearLevelId = DTO.YearLevelId,
                SchoolYearId = DTO.SchoolYearId,
            };
        }

        public static void UpdateFromDTO(this Enrollment entity, EnrollmentDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.StudentId = DTO.StudentId;
            entity.YearLevelId = DTO.YearLevelId;
            entity.SchoolYearId = DTO.SchoolYearId;
        }
    
    }
}
