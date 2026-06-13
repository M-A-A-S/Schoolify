using Schoolify.Common.DTOs.Department;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class DepartmentExtensions
    {
        public static DepartmentDTO ToDTO(this Department entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new DepartmentDTO
            {
                Id = entity.Id,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
            };
        }

        public static Department ToEntity(this DepartmentDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Department
            {
                Id = DTO.Id,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr
            };
        }

        public static void UpdateFromDTO(this Department entity, DepartmentDTO DTO)
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
