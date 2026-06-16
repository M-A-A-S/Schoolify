using Schoolify.Common.DTOs.Class;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ClassExtensions
    {
        public static ClassDTO ToDTO(this Class entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ClassDTO
            {
                Id = entity.Id,
                SubjectId = entity.SubjectId,
                TeacherId = entity.TeacherId,
                TermId = entity.TermId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                MaxScore = entity.MaxScore,

                Subject = entity.Subject?.ToDTO(),
                Teacher = entity.Teacher?.ToDTO(),
                Term = entity.Term?.ToDTO()
            };
        }

        public static Class ToEntity(this ClassDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Class
            {
                Id = DTO.Id,
                SubjectId = DTO.SubjectId,
                TeacherId = DTO.TeacherId,
                TermId = DTO.TermId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                MaxScore = DTO.MaxScore,
            };
        }

        public static void UpdateFromDTO(this Class entity, ClassDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SubjectId = DTO.SubjectId;
            entity.TeacherId = DTO.TeacherId;
            entity.TermId = DTO.TermId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.MaxScore = DTO.MaxScore;
        }
    
    }
}
