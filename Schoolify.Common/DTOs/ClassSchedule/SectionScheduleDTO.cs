using Schoolify.Common.DTOs.Period;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassSchedule
{
    public class SectionScheduleDTO
    {
        public int SectionId { get; set; }
        public string SectionNameEn { get; set; }
        public string SectionNameAr { get; set; }

        public List<PeriodDTO> Periods { get; set; } = new List<PeriodDTO>();
        public List<DayOfWeek> Days { get; set; }
        public Dictionary<int, Dictionary<DayOfWeek, ScheduleCellDTO>> Grid { get; set; } = new Dictionary<int, Dictionary<DayOfWeek, ScheduleCellDTO>>();

    }
}
