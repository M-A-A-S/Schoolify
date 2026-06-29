using Schoolify.Common.DTOs.Installment;
using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Payment
{
    public class PaymentDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Installment),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int InstallmentId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.AmountPaid),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal AmountPaid { get; set; }

        [Display(Name = nameof(Resources.SharedResource.PaymentDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [Display(Name = nameof(Resources.SharedResource.PaymentMethod),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name = nameof(Resources.SharedResource.ReceiptNumber),
ResourceType = typeof(Resources.SharedResource)
)]
//        [Required(
//ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
//ErrorMessageResourceType = typeof(Resources.SharedResource)
//)]
        public string? ReceiptNumber { get; set; }

        [Display(Name = nameof(Resources.SharedResource.TransactionReference),
ResourceType = typeof(Resources.SharedResource)
)]
//        [Required(
//ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
//ErrorMessageResourceType = typeof(Resources.SharedResource)
//)]
        public string? TransactionReference { get; set; }
        public InstallmentDTO? Installment { get; set; }

    }
}
