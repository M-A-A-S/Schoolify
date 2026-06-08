using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Department : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "Science"
        public string NameAr { get; set; } // مثل: "قسم العلوم"

        public ICollection<Subject> Subjects { get; set; }
    }
}
