using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using Schoolify.Common.DTOs.YearLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Enrollment
{
    public class EnrollmentUpsertDTO
    {
        public EnrollmentDTO Enrollment { get; set; }

        public IEnumerable<StudentDTO> Students { get; set; } = Enumerable.Empty<StudentDTO>();
        public IEnumerable<YearLevelDTO> YearLevels { get; set; } = Enumerable.Empty<YearLevelDTO>();
        public IEnumerable<SchoolYearDTO> SchoolYears { get; set; } = Enumerable.Empty<SchoolYearDTO>();
        public IEnumerable<SectionDTO> Sections { get; set; } = Enumerable.Empty<SectionDTO>();

    }
}
