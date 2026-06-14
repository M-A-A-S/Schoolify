using Schoolify.Common.DTOs.YearLevel;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class YearLevelExtensions
    {
        public static YearLevelDTO ToDTO(this YearLevel entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new YearLevelDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                LevelOrder = entity.LevelOrder,
                SchoolStageId = entity.SchoolStageId,
                SchoolStage = entity.SchoolStage?.ToDTO()
            };
        }

        public static YearLevel ToEntity(this YearLevelDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new YearLevel
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                LevelOrder = DTO.LevelOrder,
                SchoolStageId = DTO.SchoolStageId,
            };
        }

        public static void UpdateFromDTO(this YearLevel entity, YearLevelDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.LevelOrder = DTO.LevelOrder;
            entity.SchoolStageId = DTO.SchoolStageId;
        
        }
    
    }
}
