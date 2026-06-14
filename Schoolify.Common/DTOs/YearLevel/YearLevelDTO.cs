using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.YearLevel
{
    public class YearLevelDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NameEn),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameEn { get; set; } // e.g., "Grade 10"

        [Display(Name = nameof(Resources.SharedResource.NameAr),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameAr { get; set; } // مثل: "الصف العاشر"

        [Display(Name = nameof(Resources.SharedResource.LevelOrder),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int LevelOrder { get; set; }

        [Display(Name = nameof(Resources.SharedResource.SchoolStage),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SchoolStageId { get; set; }
    }
}
