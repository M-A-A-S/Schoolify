using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Payment : BaseEntity
    {
        public int InstallmentId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string? ReceiptNumber { get; set; }
        public string? TransactionReference { get; set; }
        public Installment Installment { get; set; }
    }
}
