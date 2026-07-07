using Schoolify.Common.DTOs.StudentGuardian;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class StudentGuardianExtensions
    {
        public static StudentGuardianDTO ToDTO(this StudentGuardian entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentGuardianDTO
            {
                Id = entity.Id,
                GuardianTypeId = entity.GuardianTypeId,
                GuardianId = entity.GuardianId,
                StudentId = entity.StudentId,

                Student = entity.Student?.ToDTO(),
                GuardianType = entity.GuardianType?.ToDTO(),
                Guardian = entity.Guardian?.ToDTO(),
            };
        }

        public static StudentGuardian ToEntity(this StudentGuardianDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new StudentGuardian
            {
                Id = DTO.Id,
                GuardianTypeId = DTO.GuardianTypeId,
                GuardianId = DTO.GuardianId,
                StudentId = DTO.StudentId,
            };
        }

        public static void UpdateFromDTO(this StudentGuardian entity, StudentGuardianDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.GuardianTypeId = DTO.GuardianTypeId;
            entity.GuardianId = DTO.GuardianId;
            entity.StudentId = DTO.StudentId;
        }
    
    }
}
