using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.DTOs.GuardianType;
using Schoolify.Common.DTOs.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentGuardian
{
    public class StudentGuardianDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.GuardianType),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int GuardianTypeId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Guardian),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int GuardianId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Student),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int StudentId { get; set; }


        public StudentDTO? Student { get; set; }
        public GuardianTypeDTO? GuardianType { get; set; }
        public GuardianDTO? Guardian { get; set; }
    }
}
