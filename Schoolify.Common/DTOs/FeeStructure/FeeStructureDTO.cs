using Schoolify.Common.DTOs.FeeItem;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.YearLevel;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.FeeStructure
{
    public class FeeStructureDTO
    {
        public int Id { get; set; }
        public int SchoolYearId { get; set; }
        public int YearLevelId { get; set; }

        public SchoolYearDTO? SchoolYear { get; set; }
        public YearLevelDTO? YearLevel { get; set; }

        public ICollection<FeeItemDTO> FeeItems { get; set; } = new List<FeeItemDTO>();

    }
}
