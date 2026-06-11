using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Enums
{
    public enum Gender
    {
        [Display(Name = nameof(Resources.SharedResource.Male), ResourceType = typeof(Resources.SharedResource))]
        Male = 1,
        [Display(Name = nameof(Resources.SharedResource.Female), ResourceType = typeof(Resources.SharedResource))]
        Female = 2,
        [Display(Name = nameof(Resources.SharedResource.Unknown), ResourceType = typeof(Resources.SharedResource))]
        Unknown = 3
    }
}
