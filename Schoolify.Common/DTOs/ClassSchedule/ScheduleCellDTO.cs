using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassSchedule
{
    public class ScheduleCellDTO
    {
        public int ClassScheduleId { get; set; }
        public string ClassNameEn { get; set; }
        public string ClassNameAr { get; set; }
        public string TeacherName { get; set; }
        public string ClassroomNameEn { get; set; }
        public string ClassroomNameAr { get; set; }
    }
}
