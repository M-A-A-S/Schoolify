using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using Schoolify.Common.DTOs.YearLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.FeeStructure
{
    public class FeeStructureUpsertDTO
    {
        public FeeStructureDTO FeeStructure { get; set; }

        public IEnumerable<SchoolYearDTO> SchoolYears { get; set; } = Enumerable.Empty<SchoolYearDTO>();
        public IEnumerable<YearLevelDTO> YearLevels { get; set; } = Enumerable.Empty<YearLevelDTO>();

    }
}
