using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class SchoolStage : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "Primary"
        public string NameAr { get; set; } // مثل: "الابتدائية"

        public ICollection<YearLevel> YearLevels { get; set; }
    }
}
