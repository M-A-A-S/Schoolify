using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Subject : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string NameEn { get; set; } // e.g., "Chemistry"
        public string NameAr { get; set; }  // مثل: "الكيمياء"

        public Department Department { get; set; }
        public ICollection<SubjectClass> SubjectClasses { get; set; } = new List<SubjectClass>();
    }
}
