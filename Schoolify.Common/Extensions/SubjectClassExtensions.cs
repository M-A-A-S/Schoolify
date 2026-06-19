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
                SectionId = entity.SectionId,
                TermId = entity.TermId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                MaxScore = entity.MaxScore,
                
                Section = entity.Section?.ToDTO(),
                Subject = entity.Subject?.ToDTO(),
                Term = entity.Term?.ToDTO(),
                SubjectClassTeachers = entity.SubjectClassTeachers?.Select(sct => sct.ToDTO()).ToList()
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
                SectionId = DTO.SectionId,
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

            entity.SectionId = DTO.SectionId;
            entity.SubjectId = DTO.SubjectId;
            entity.TermId = DTO.TermId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.MaxScore = DTO.MaxScore;
        }
    
    }
}
