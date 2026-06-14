using Schoolify.Common.DTOs.Period;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class PeriodExtensions
    {
        public static PeriodDTO ToDTO(this Period entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new PeriodDTO
            {
                Id = entity.Id,
                SchoolYearId = entity.SchoolYearId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                StartTime = entity.StartTime,
                EndTime = entity.EndTime,
            };
        }

        public static Period ToEntity(this PeriodDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Period
            {
                Id = DTO.Id,
                SchoolYearId = DTO.SchoolYearId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                StartTime = DTO.StartTime,
                EndTime = DTO.EndTime
            };
        }

        public static void UpdateFromDTO(this Period entity, PeriodDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SchoolYearId = DTO.SchoolYearId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.StartTime = DTO.StartTime;
            entity.EndTime = DTO.EndTime;
        }
    
    }
}
