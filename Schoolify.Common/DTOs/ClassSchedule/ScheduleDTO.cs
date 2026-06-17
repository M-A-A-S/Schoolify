using Schoolify.Common.DTOs.Period;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.ClassSchedule
{
    public class ScheduleDTO
    {
        public List<PeriodDTO> Periods { get; set; }
        public List<DayOfWeek> Days { get; set; }

        public Dictionary<int, Dictionary<DayOfWeek, ScheduleCellDTO>> Grid { get; set; }

    }
}
