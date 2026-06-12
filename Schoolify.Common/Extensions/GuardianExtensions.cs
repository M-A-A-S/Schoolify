using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class GuardianExtensions
    {
        public static GuardianDTO ToDTO(this Guardian entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new GuardianDTO
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                SecondName = entity.SecondName,
                ThirdName = entity.ThirdName,
                ForthName = entity.ForthName,
                PhoneNumber = entity.PhoneNumber,
                EmailAddress = entity.EmailAddress,
            };
        }

        public static Guardian ToEntity(this GuardianDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Guardian
            {
                Id = DTO.Id,
                FirstName = DTO.FirstName,
                SecondName = DTO.SecondName,
                ThirdName = DTO.ThirdName,
                ForthName = DTO.ForthName,
                PhoneNumber = DTO.PhoneNumber,
                EmailAddress = DTO.EmailAddress,
            };
        }

        public static void UpdateFromDTO(this Guardian entity, GuardianDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.FirstName = DTO.FirstName;
            entity.SecondName = DTO.SecondName;
            entity.ThirdName = DTO.ThirdName;
            entity.ForthName = DTO.ForthName;
            entity.PhoneNumber = DTO.PhoneNumber;
            entity.EmailAddress = DTO.EmailAddress;
        }
    }
}
