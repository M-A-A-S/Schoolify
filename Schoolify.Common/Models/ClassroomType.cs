using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class ClassroomType : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "Science Lab", "Standard Classroom"
        public string NameAr { get; set; } // مثل: "مختبر العلوم"، "فصل دراسي عادي"

        public ICollection<Classroom> Classrooms { get; set; }
    }
}
