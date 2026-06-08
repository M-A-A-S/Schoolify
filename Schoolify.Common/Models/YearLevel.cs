using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class YearLevel : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "Grade 10"
        public string NameAr { get; set; } // مثل: "الصف العاشر"
        public int LevelOrder { get; set; }
        public int SchoolStageId { get; set; }


        public SchoolStage SchoolStage { get; set; }
        public ICollection<StudentYearLevel> StudentYearLevels { get; set; }
    }
}
