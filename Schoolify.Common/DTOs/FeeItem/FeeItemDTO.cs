using Schoolify.Common.DTOs.FeeStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.FeeItem
{
    public class FeeItemDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.FeeStructure),
ResourceType = typeof(Resources.SharedResource)
)]
//        [Required(
//ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
//ErrorMessageResourceType = typeof(Resources.SharedResource)
//)]
        public int FeeStructureId { get; set; }

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

        [Display(Name = nameof(Resources.SharedResource.Amount),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal Amount { get; set; }

        public FeeStructureDTO? FeeStructure { get; set; }

    }
}
