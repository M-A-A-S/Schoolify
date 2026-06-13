using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class SubjectExtensions
    {
        public static SubjectDTO ToDTO(this Subject entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new SubjectDTO
            {
                Id = entity.Id,
                DepartmentId = entity.DepartmentId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr
            };
        }

        public static Subject ToEntity(this SubjectDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Subject
            {
                Id = DTO.Id,
                DepartmentId = DTO.DepartmentId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr
            };
        }

        public static void UpdateFromDTO(this Subject entity, SubjectDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.DepartmentId = DTO.DepartmentId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
        }
    
    }
}
