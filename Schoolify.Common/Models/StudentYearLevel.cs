using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class StudentYearLevel : BaseEntity
    {
        public int StudentId { get; set; }
        public int YearLevelId { get; set; }
        public int SchoolYearId { get; set; }
        public decimal? FinalYearScore { get; set; }

        public Student Student { get; set; }
        public YearLevel YearLevel { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
