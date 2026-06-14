using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Class
{
    public class ClassDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Subject),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SubjectId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Teacher),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int TeacherId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Term),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int TermId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NameEn),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameEn { get; set; }


        [Display(Name = nameof(Resources.SharedResource.NameAr),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameAr { get; set; }

        [Display(Name = nameof(Resources.SharedResource.MaxScore),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal MaxScore { get; set; } 
    }
}
