using Schoolify.Common.DTOs.FeeStructure;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class FeeStructureExtensions
    {
        public static FeeStructureDTO ToDTO(this FeeStructure entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new FeeStructureDTO
            {
                Id = entity.Id,
                SchoolYearId = entity.SchoolYearId,
                YearLevelId = entity.YearLevelId,
                
                SchoolYear = entity.SchoolYear?.ToDTO(),
                YearLevel = entity.YearLevel?.ToDTO(),
                FeeItems = entity?.FeeItems?.Select(x => x.ToDTO())?.ToList()
            };
        }

        public static FeeStructure ToEntity(this FeeStructureDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new FeeStructure
            {
                Id = DTO.Id,
                SchoolYearId = DTO.SchoolYearId,
                YearLevelId = DTO.YearLevelId,
            };
        }

        public static void UpdateFromDTO(this FeeStructure entity, FeeStructureDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SchoolYearId = DTO.SchoolYearId;
            entity.YearLevelId = DTO.YearLevelId;
        }

    }
}
