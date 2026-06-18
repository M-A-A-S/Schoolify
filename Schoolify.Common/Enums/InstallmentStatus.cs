using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Enums
{
    public enum InstallmentStatus
    {
        Pending = 1,         // مستحق
        PartiallyPaid = 2,   // مدفوع جزئياً
        Paid = 3,            // مدفوع
        Overdue = 4          // متأخر
    }
}
