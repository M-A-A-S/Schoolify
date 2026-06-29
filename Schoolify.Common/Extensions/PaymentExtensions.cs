using Schoolify.Common.DTOs.Payment;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class PaymentExtensions
    {
        public static PaymentDTO ToDTO(this Payment entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new PaymentDTO
            {
                Id = entity.Id,
                InstallmentId = entity.InstallmentId,
                AmountPaid = entity.AmountPaid,
                PaymentDate = entity.PaymentDate,
                PaymentMethod = entity.PaymentMethod,
                ReceiptNumber = entity.ReceiptNumber,
                TransactionReference = entity.TransactionReference,
                Installment = entity.Installment?.ToDTO()
            };
        }

        public static Payment ToEntity(this PaymentDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Payment
            {
                Id = DTO.Id,
                InstallmentId = DTO.InstallmentId,
                AmountPaid = DTO.AmountPaid,
                PaymentDate = DTO.PaymentDate,
                PaymentMethod = DTO.PaymentMethod,
                ReceiptNumber = DTO.ReceiptNumber,
                TransactionReference = DTO.TransactionReference,
            };
        }

        public static void UpdateFromDTO(this Payment entity, PaymentDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.InstallmentId = DTO.InstallmentId;
            entity.AmountPaid = DTO.AmountPaid;
            entity.PaymentDate = DTO.PaymentDate;
            entity.PaymentMethod = DTO.PaymentMethod;
            entity.ReceiptNumber = DTO.ReceiptNumber;
            entity.TransactionReference = DTO.TransactionReference;
        }

    }
}
