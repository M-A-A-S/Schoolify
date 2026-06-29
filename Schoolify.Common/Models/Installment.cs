using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Installment : BaseEntity
    {
        public int EnrollmentId { get; set; }
        public int InstallmentNumber { get; set; }
        public decimal Amount { get; set; }
        public DateOnly DueDate { get; set; }
        public InstallmentStatus Status { get; set; }

        public Enrollment Enrollment { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
