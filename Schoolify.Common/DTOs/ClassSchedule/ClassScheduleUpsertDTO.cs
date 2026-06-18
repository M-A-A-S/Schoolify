using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Classroom;
using Schoolify.Common.DTOs.Period;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassSchedule
{
    public class ClassScheduleUpsertDTO
    {
        public ClassScheduleDTO ClassSchedule { get; set; }

        public IEnumerable<SubjectClassDTO> Classes { get; set; } = Enumerable.Empty<SubjectClassDTO>();
        public IEnumerable<PeriodDTO> Periods { get; set; } = Enumerable.Empty<PeriodDTO>();
        public IEnumerable<ClassroomDTO> Classrooms { get; set; } = Enumerable.Empty<ClassroomDTO>();
        public IEnumerable<DayDTO> Days { get; set; } = Enumerable.Empty<DayDTO>();

    }
}
