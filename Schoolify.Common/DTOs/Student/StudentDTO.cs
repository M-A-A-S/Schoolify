using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Student
{
    public class StudentDTO
    {
        public int Id { get; set; }
        [Display(Name = nameof(Resources.SharedResource.FirstName),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string FirstName { get; set; }
        [Display(Name = nameof(Resources.SharedResource.SecondName),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string SecondName { get; set; }

        [Display(Name = nameof(Resources.SharedResource.ThirdName),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string ThirdName { get; set; }
        [Display(Name = nameof(Resources.SharedResource.ForthName),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]

        public string ForthName { get; set; }

        [Display(Name = nameof(Resources.SharedResource.DateOfBirth),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateOnly DateOfBirth { get; set; }

        [Display(Name = nameof(Resources.SharedResource.EnrolmentDate),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public DateOnly EnrolmentDate { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Gender),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public Gender Gender { get; set; }


        public string FullName => $"{FirstName} {SecondName} {ThirdName} {ForthName}";
    }
}
