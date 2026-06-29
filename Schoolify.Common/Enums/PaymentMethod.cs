using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Enums
{
    public enum PaymentMethod
    {
        [Display(Name = nameof(Resources.SharedResource.Cash), ResourceType = typeof(Resources.SharedResource))]
        Cash = 1, // نقداً
        [Display(Name = nameof(Resources.SharedResource.Bankak), ResourceType = typeof(Resources.SharedResource))]
        Bankak = 2, // بنكك
        [Display(Name = nameof(Resources.SharedResource.Fawry), ResourceType = typeof(Resources.SharedResource))]
        Fawry = 3, // فوري
    }
}
