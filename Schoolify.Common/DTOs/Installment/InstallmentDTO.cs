using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.DTOs.Payment;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Installment
{
    public class InstallmentDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Enrollment),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int EnrollmentId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.InstallmentNumber),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int InstallmentNumber { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Amount),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal Amount { get; set; }

        [Display(Name = nameof(Resources.SharedResource.DueDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateOnly DueDate { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Status),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public InstallmentStatus Status { get; set; }

        public EnrollmentDTO? Enrollment { get; set; }
        public ICollection<PaymentDTO> Payments { get; set; } = new List<PaymentDTO>();

    }
}
