using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    // الشعبة
    public class Section : BaseEntity
    {
        public int YearLevelId { get; set; }
        public string NameEn { get; set; } // A
        public string NameAr { get; set; } // أ
        public YearLevel YearLevel { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<SubjectClass> SubjectClasses { get; set; } = new List<SubjectClass>();

    }
}
