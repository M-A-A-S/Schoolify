using Schoolify.Common.DTOs.SchoolStage;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SchoolStageExtensions
    {
        public static SchoolStageDTO ToDTO(this SchoolStage entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SchoolStageDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr
            };
              
        }

        public static SchoolStage ToEntity(this SchoolStageDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new SchoolStage
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr
            };
        }

        public static void UpdateFromDTO(this SchoolStage entity, SchoolStageDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
        
        }
    }
}
