using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Period : BaseEntity
    {
        public int SchoolYearId { get; set; }
        public string NameEn { get; set; } // e.g., "1st Period"
        public string NameAr { get; set; } // مثل: "الفترة الأولى"
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public SchoolYear SchoolYear { get; set; }
        public ICollection<ClassSchedule> ClassSchedules { get; set; }
    }
}
