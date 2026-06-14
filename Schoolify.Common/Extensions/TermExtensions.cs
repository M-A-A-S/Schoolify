using Schoolify.Common.DTOs.Term;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class TermExtensions
    {
        public static TermDTO ToDTO(this Term entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new TermDTO
            {
                Id = entity.Id,
                SchoolYearId = entity.SchoolYearId,
                TermNumber = entity.TermNumber,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
            };
        }

        public static Term ToEntity(this TermDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Term
            {
                Id = DTO.Id,
                SchoolYearId = DTO.SchoolYearId,
                TermNumber = DTO.TermNumber,
                StartDate = DTO.StartDate,
                EndDate = DTO.EndDate,
            };
        }

        public static void UpdateFromDTO(this Term entity, TermDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SchoolYearId = DTO.SchoolYearId;
            entity.TermNumber = DTO.TermNumber;
            entity.StartDate = DTO.StartDate;
            entity.EndDate = DTO.EndDate;
        }
    
    }
}
