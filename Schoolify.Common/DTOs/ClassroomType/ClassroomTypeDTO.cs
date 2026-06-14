using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassroomType
{
    public class ClassroomTypeDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NameEn),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameEn { get; set; } // e.g., "Science Lab", "Standard Classroom"

        [Display(Name = nameof(Resources.SharedResource.NameAr),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameAr { get; set; } // مثل: "مختبر العلوم"، "فصل دراسي عادي"
    }
}
