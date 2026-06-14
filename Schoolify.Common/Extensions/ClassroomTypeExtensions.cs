using Schoolify.Common.DTOs.ClassroomType;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ClassroomTypeExtensions
    {
        public static ClassroomTypeDTO ToDTO(this ClassroomType entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ClassroomTypeDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
            };
        }

        public static ClassroomType ToEntity(this ClassroomTypeDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new ClassroomType
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
            };
        }

        public static void UpdateFromDTO(this ClassroomType entity, ClassroomTypeDTO DTO)
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
