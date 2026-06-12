using Schoolify.Common.DTOs.GuardianType;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class GuardianTypeExtensions
    {
        public static GuardianTypeDTO ToDTO(this GuardianType entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new GuardianTypeDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr
            };
        }

        public static GuardianType ToEntity(this GuardianTypeDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new GuardianType
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr
            };
        }

        public static void UpdateFromDTO(this GuardianType entity, GuardianTypeDTO DTO)
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
