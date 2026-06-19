using Schoolify.Common.DTOs.Section;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SectionExtensions
    {
        public static SectionDTO ToDTO(this Section entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SectionDTO
            {
                Id = entity.Id,
                YearLevelId = entity.YearLevelId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                YearLevel = entity.YearLevel?.ToDTO()
            };
        }

        public static Section ToEntity(this SectionDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Section
            {
                Id = DTO.Id,
                YearLevelId = DTO.YearLevelId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
            };
        }

        public static void UpdateFromDTO(this Section entity, SectionDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.YearLevelId = DTO.YearLevelId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
        }

    }
}
