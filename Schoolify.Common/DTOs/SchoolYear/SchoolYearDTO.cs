using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.SchoolYear
{
    public class SchoolYearDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NameEn),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameEn { get; set; } // e.g., "2025-2026"

        [Display(Name = nameof(Resources.SharedResource.NameAr),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameAr { get; set; } // مثل: "٢٠٢٥-٢٠٢٦"

        [Display(Name = nameof(Resources.SharedResource.StartDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateOnly StartDate { get; set; }

        [Display(Name = nameof(Resources.SharedResource.EndDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateOnly EndDate { get; set; }
    }
}
