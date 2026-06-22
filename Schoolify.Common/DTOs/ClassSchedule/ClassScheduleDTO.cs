using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Classroom;
using Schoolify.Common.DTOs.Period;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.SubjectClassTeacher;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassSchedule
{
    public class ClassScheduleDTO
    {
        public int Id { get; set; }

//        [Display(Name = nameof(Resources.SharedResource.Class),
//ResourceType = typeof(Resources.SharedResource)
//)]
//        [Required(
//ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
//ErrorMessageResourceType = typeof(Resources.SharedResource)
//)]
//        public int ClassId { get; set; }
        [Display(Name = nameof(Resources.SharedResource.SubjectClassTeacher),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SubjectClassTeacherId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Period),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int PeriodId { get; set; }


        [Display(Name = nameof(Resources.SharedResource.Section),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SectionId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Classroom),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int ClassroomId { get; set; }
        [Display(Name = nameof(Resources.SharedResource.DayOfWeek),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]


        public DayOfWeek DayOfWeek { get; set; } // C# built-in enum for days of the week

        //public SubjectClassDTO? Class { get; set; }
        public SubjectClassTeacherDTO? SubjectClassTeacher { get; set; }
        public PeriodDTO? Period { get; set; }
        public ClassroomDTO? Classroom { get; set; }
        public SectionDTO? Section { get; set; }
    }
}
