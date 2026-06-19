using Schoolify.Common.DTOs.YearLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Section
{
    public class SectionDTO
    {  
        public int Id { get; set; }
        public int YearLevelId { get; set; }
        //public int? ClassroomId { get; set; }
        public string NameEn { get; set; } // A
        public string NameAr { get; set; } // أ
        public YearLevelDTO? YearLevel { get; set; }
    }
}
