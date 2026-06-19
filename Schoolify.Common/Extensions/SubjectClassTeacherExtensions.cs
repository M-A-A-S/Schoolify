using Schoolify.Common.DTOs.SubjectClassTeacher;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SubjectClassTeacherExtensions
    {
        public static SubjectClassTeacherDTO ToDTO(this SubjectClassTeacher entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SubjectClassTeacherDTO
            {
                Id = entity.Id,
                SubjectClassId = entity.SubjectClassId,
                TeacherId = entity.TeacherId,
                IsMainTeacher = entity.IsMainTeacher,

                Teacher = entity.Teacher?.ToDTO(),

            };
        }

        public static SubjectClassTeacher ToEntity(this SubjectClassTeacherDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new SubjectClassTeacher
            {
                Id = DTO.Id,
                SubjectClassId = DTO.SubjectClassId,
                TeacherId = DTO.TeacherId,
                IsMainTeacher = DTO.IsMainTeacher,
            };
        }

        public static void UpdateFromDTO(this SubjectClassTeacher entity, SubjectClassTeacherDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SubjectClassId = DTO.SubjectClassId;
            entity.TeacherId = DTO.TeacherId;
            entity.IsMainTeacher = DTO.IsMainTeacher;
        }

    }
}
