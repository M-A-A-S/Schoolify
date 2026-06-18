using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class FeeStructure : BaseEntity
    {
        public int SchoolYearId { get; set; }
        public int YearLevelId { get; set; }

        public SchoolYear SchoolYear { get; set; }
        public YearLevel YearLevel { get; set; }

        public ICollection<FeeItem> FeeItems { get; set; }
    }
}
