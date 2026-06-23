using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Enums
{
    public enum EnrollmentStatus
    {
        [Display(Name = nameof(Resources.SharedResource.Active), 
            ResourceType = typeof(Resources.SharedResource))]
        Active = 1,     // نشط

        [Display(Name = nameof(Resources.SharedResource.Suspended),
    ResourceType = typeof(Resources.SharedResource))]
        Suspended = 2,  // موقوف

        [Display(Name = nameof(Resources.SharedResource.Graduated),
    ResourceType = typeof(Resources.SharedResource))]
        Graduated = 3,  // متخرج

        [Display(Name = nameof(Resources.SharedResource.Transferred),
    ResourceType = typeof(Resources.SharedResource))]
        Transferred = 4 // منتقل
    }
}
