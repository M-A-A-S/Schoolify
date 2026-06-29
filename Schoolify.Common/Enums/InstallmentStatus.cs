using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Enums
{
    public enum InstallmentStatus
    {
        [Display(Name = nameof(Resources.SharedResource.Pending), ResourceType = typeof(Resources.SharedResource))]
        Pending = 1,         // مستحق
        [Display(Name = nameof(Resources.SharedResource.PartiallyPaid), ResourceType = typeof(Resources.SharedResource))]
        PartiallyPaid = 2,   // مدفوع جزئياً
        [Display(Name = nameof(Resources.SharedResource.Paid), ResourceType = typeof(Resources.SharedResource))]
        Paid = 3,            // مدفوع
        [Display(Name = nameof(Resources.SharedResource.Overdue), ResourceType = typeof(Resources.SharedResource))]
        Overdue = 4          // متأخر
    }
}
