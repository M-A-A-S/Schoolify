using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Class : BaseEntity
    {
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int TermId { get; set; }
        public string NameEn { get; set; } // e.g., "Math-Grade10-A"
        public string NameAr { get; set; } // مثل: "رياضيات-الصف العاشر-أ"
        public decimal MaxScore { get; set; } // Flexible Max Grade improvement

        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
        public Term Term { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<ClassSchedule> ClassSchedules { get; set; }
    }
}
