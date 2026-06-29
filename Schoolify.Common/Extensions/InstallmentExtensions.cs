using Schoolify.Common.DTOs.Installment;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class InstallmentExtensions
    {
        public static InstallmentDTO ToDTO(this Installment entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new InstallmentDTO
            {
                Id = entity.Id,
                EnrollmentId = entity.EnrollmentId,
                InstallmentNumber = entity.InstallmentNumber,
                Amount = entity.Amount,
                DueDate = entity.DueDate,
                Status = entity.Status,
                Enrollment = entity.Enrollment?.ToDTO()
            };
        }

        public static Installment ToEntity(this InstallmentDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Installment
            {
                Id = DTO.Id,
                EnrollmentId = DTO.EnrollmentId,
                InstallmentNumber = DTO.InstallmentNumber,
                Amount = DTO.Amount,
                DueDate = DTO.DueDate,
                Status = DTO.Status,
            };
        }

        public static void UpdateFromDTO(this Installment entity, InstallmentDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.EnrollmentId = DTO.EnrollmentId;
            entity.InstallmentNumber = DTO.InstallmentNumber;
            entity.Amount = DTO.Amount;
            entity.DueDate = DTO.DueDate;
            entity.Status = DTO.Status;
        }

    }
}
