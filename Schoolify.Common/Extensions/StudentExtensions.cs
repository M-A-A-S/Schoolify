using Schoolify.Common.DTOs.Student;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class StudentExtensions
    {
        public static StudentDTO ToDTO(this Student entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new StudentDTO
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                SecondName = entity.SecondName,
                ThirdName = entity.ThirdName,
                ForthName = entity.ForthName,
                DateOfBirth = entity.DateOfBirth,
                EnrolmentDate = entity.EnrolmentDate,
                Gender = entity.Gender,
            };
        }

        public static Student ToEntity(this StudentDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Student
            {
                Id = DTO.Id,
                FirstName = DTO.FirstName,
                SecondName = DTO.SecondName,
                ThirdName = DTO.ThirdName,
                ForthName = DTO.ForthName,
                DateOfBirth = DTO.DateOfBirth,
                EnrolmentDate = DTO.EnrolmentDate,
                Gender = DTO.Gender,
            };
        }

        public static void UpdateFromDTO(this Student entity, StudentDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.FirstName = DTO.FirstName;
            entity.SecondName = DTO.SecondName;
            entity.ThirdName = DTO.ThirdName;
            entity.ForthName = DTO.ForthName;
            entity.DateOfBirth = DTO.DateOfBirth;
            entity.EnrolmentDate = DTO.EnrolmentDate;
            entity.Gender = DTO.Gender;
        }
    }
}
