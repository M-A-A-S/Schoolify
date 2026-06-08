using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class ClassSchedule : BaseEntity
    {
        public int ClassId { get; set; }
        public int PeriodId { get; set; }
        public int ClassroomId { get; set; }
        public DayOfWeek DayOfWeek { get; set; } // C# built-in enum for days of the week

        public Class Class { get; set; }
        public Period Period { get; set; }
        public Classroom Classroom { get; set; }
    }
}
