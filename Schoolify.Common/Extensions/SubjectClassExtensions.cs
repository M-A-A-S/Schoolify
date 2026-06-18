using Schoolify.Common.DTOs.Class;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SubjectClassExtensions
    {
        public static SubjectClassDTO ToDTO(this SubjectClass entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SubjectClassDTO
            {
                Id = entity.Id,
                SubjectId = entity.SubjectId,
                TermId = entity.TermId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                MaxScore = entity.MaxScore,

                Subject = entity.Subject?.ToDTO(),
                Term = entity.Term?.ToDTO()
            };
        }

        public static SubjectClass ToEntity(this SubjectClassDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new SubjectClass
            {
                Id = DTO.Id,
                SubjectId = DTO.SubjectId,
                TermId = DTO.TermId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                MaxScore = DTO.MaxScore,
            };
        }

        public static void UpdateFromDTO(this SubjectClass entity, SubjectClassDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SubjectId = DTO.SubjectId;
            entity.TermId = DTO.TermId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.MaxScore = DTO.MaxScore;
        }
    
    }
}
