using Schoolify.Common.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ScoreRange
{
    public class ScoreRangeDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.MinScore),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal MinScore { get; set; } // e.g., 90.00%

        [Display(Name = nameof(Resources.SharedResource.MaxScore),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]

        [DateGreaterThan(nameof(MinScore),
        ErrorMessageResourceType = typeof(Resources.SharedResource),
        ErrorMessageResourceName = nameof(Resources.SharedResource.MinMaxError))]
        public decimal MaxScore { get; set; } // e.g., 100.00%

        [Display(Name = nameof(Resources.SharedResource.Grade),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string Grade { get; set; }     // e.g., "A"
    }
}
