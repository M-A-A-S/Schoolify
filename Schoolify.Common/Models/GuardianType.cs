using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class GuardianType : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "Father"
        public string NameAr { get; set; } // مثل: "الأب"

        public ICollection<StudentGuardian> StudentGuardians { get; set; }
    }
}
