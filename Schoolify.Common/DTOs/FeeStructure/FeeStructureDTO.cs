using Schoolify.Common.DTOs.FeeItem;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.YearLevel;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.FeeStructure
{
    public class FeeStructureDTO
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

        [Display(Name = nameof(Resources.SharedResource.YearLevel),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int YearLevelId { get; set; }

        public SchoolYearDTO? SchoolYear { get; set; }
        public YearLevelDTO? YearLevel { get; set; }

        public ICollection<FeeItemDTO> FeeItems { get; set; } = new List<FeeItemDTO>();

    }
}
