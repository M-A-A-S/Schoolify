using Schoolify.Common.DTOs.FeeItem;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class FeeItemExtensions
    {
        public static FeeItemDTO ToDTO(this FeeItem entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new FeeItemDTO
            {
                Id = entity.Id,
                FeeStructureId = entity.FeeStructureId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                Amount = entity.Amount,
            };
        }

        public static FeeItem ToEntity(this FeeItemDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new FeeItem
            {
                Id = DTO.Id,
                FeeStructureId = DTO.FeeStructureId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                Amount = DTO.Amount,
            };
        }

        public static void UpdateFromDTO(this FeeItem entity, FeeItemDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.FeeStructureId = DTO.FeeStructureId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.Amount = DTO.Amount;
        }

    }
}
