using Schoolify.Common.DTOs.Classroom;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ClassroomExtensions
    {
        public static ClassroomDTO ToDTO(this Classroom entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ClassroomDTO
            {
                Id = entity.Id,
                RoomTypeId = entity.RoomTypeId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                Capacity = entity.Capacity,

                RoomType = entity?.RoomType?.ToDTO()
            };
        }

        public static Classroom ToEntity(this ClassroomDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Classroom
            {
                Id = DTO.Id,
                RoomTypeId = DTO.RoomTypeId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                Capacity = DTO.Capacity,
            };
        }

        public static void UpdateFromDTO(this Classroom entity, ClassroomDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.RoomTypeId = DTO.RoomTypeId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.Capacity = DTO.Capacity;
        }
    
    }
}
