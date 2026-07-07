using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Guardian
{
    public class GuardianDTO
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

        [Display(Name = nameof(Resources.SharedResource.Email),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        [EmailAddress(
ErrorMessageResourceType = typeof(Resources.SharedResource),
ErrorMessageResourceName = nameof(Resources.SharedResource.InvalidEmail)
)]
        public string EmailAddress { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Phone),
ResourceType = typeof(Resources.SharedResource)
)]

        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        [RegularExpression(
    @"^(?:\+249|0)(?:[1-9][0-9])[0-9]{7}$",
    ErrorMessageResourceType = typeof(Resources.SharedResource),
    ErrorMessageResourceName = nameof(Resources.SharedResource.InvalidPhone)
)]
        public string PhoneNumber { get; set; }


        public string FullName => $"{FirstName} {SecondName} {ThirdName} {ForthName}";
    }
}
