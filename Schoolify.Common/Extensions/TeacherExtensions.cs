using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class TeacherExtensions
    {
        public static TeacherDTO ToDTO(this Teacher entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new TeacherDTO
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                SecondName = entity.SecondName,
                ThirdName = entity.ThirdName,
                ForthName = entity.ForthName,
                Gender = entity.Gender,
                HireDate = entity.HireDate,
                PhoneNumber = entity.PhoneNumber,
                EmailAddress = entity.EmailAddress,
            };
        }

        public static Teacher ToEntity(this TeacherDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Teacher
            {
                Id = DTO.Id,
                FirstName = DTO.FirstName,
                SecondName = DTO.SecondName,
                ThirdName = DTO.ThirdName,
                ForthName = DTO.ForthName,
                Gender = DTO.Gender,
                HireDate = DTO.HireDate,
                PhoneNumber = DTO.PhoneNumber,
                EmailAddress = DTO.EmailAddress,
            };
        }

        public static void UpdateFromDTO(this Teacher entity, TeacherDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.FirstName = DTO.FirstName;
            entity.SecondName = DTO.SecondName;
            entity.ThirdName = DTO.ThirdName;
            entity.ForthName = DTO.ForthName;
            entity.Gender = DTO.Gender;
            entity.HireDate = DTO.HireDate;
            entity.PhoneNumber = DTO.PhoneNumber;
            entity.EmailAddress = DTO.EmailAddress;
        }
    }
}
