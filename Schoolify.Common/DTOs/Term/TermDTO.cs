using Schoolify.Common.DTOs.SchoolYear;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Term
{
    public class TermDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.SchoolYear),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SchoolYearId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.TermNumber),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int TermNumber { get; set; }

        [Display(Name = nameof(Resources.SharedResource.StartDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateTime StartDate { get; set; }

        [Display(Name = nameof(Resources.SharedResource.EndDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateTime EndDate { get; set; }

        public SchoolYearDTO? SchoolYear { get; set; }
    }
}
