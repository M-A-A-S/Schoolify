using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentClass
{
    internal class StudentClassDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Class),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int ClassId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Student),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int StudentId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.MarksObtained),
ResourceType = typeof(Resources.SharedResource)
)]
        public decimal? MarksObtained { get; set; } // The actual grade earned
    }
}
