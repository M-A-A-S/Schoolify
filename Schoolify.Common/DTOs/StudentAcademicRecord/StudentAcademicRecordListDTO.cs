using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.YearLevel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentAcademicRecord
{
    public class StudentAcademicRecordListDTO
    {
        [Display(Name = nameof(Resources.SharedResource.SchoolYear),
ResourceType = typeof(Resources.SharedResource)
)]
        public int SchoolYearId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Section),
ResourceType = typeof(Resources.SharedResource)
)]
        public int SectionId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.YearLevel),
ResourceType = typeof(Resources.SharedResource)
)]
        public int YearLevelId { get; set; }


        //public List<EnrollmentDTO> Enrollments = new List<EnrollmentDTO>();

        //public List<YearLevelDTO> YearLevels = new List<YearLevelDTO>();
        //public List<SchoolYearDTO> SchoolYears = new List<SchoolYearDTO>();
        //public List<SectionDTO> Sections = new List<SectionDTO>();


        // ASP.NET Core model binding binds properties, not fields.
        public List<EnrollmentDTO> Enrollments { get; set; } = new();
        public List<YearLevelDTO> YearLevels { get; set; } = new();
        public List<SchoolYearDTO> SchoolYears { get; set; } = new();
        public List<SectionDTO> Sections { get; set; } = new();
    }
}
