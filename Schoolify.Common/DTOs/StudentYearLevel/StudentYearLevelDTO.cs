using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentYearLevel
{
    public class StudentYearLevelDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Student),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int StudentId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.YearLevel),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int YearLevelId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.SchoolYear),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SchoolYearId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.FinalYearScore),
ResourceType = typeof(Resources.SharedResource)
)]
        public decimal? FinalYearScore { get; set; }
    }
}
