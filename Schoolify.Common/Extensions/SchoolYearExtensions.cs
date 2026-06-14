using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SchoolYearExtensions
    {
        public static SchoolYearDTO ToDTO(this SchoolYear entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SchoolYearDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate
            };
        }

        public static SchoolYear ToEntity(this SchoolYearDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new SchoolYear
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                StartDate = DTO.StartDate,
                EndDate = DTO.EndDate
            };
        }

        public static void UpdateFromDTO(this SchoolYear entity, SchoolYearDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.StartDate = DTO.StartDate;
            entity.EndDate = DTO.EndDate;
        }
    
    }
}
