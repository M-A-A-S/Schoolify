using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Term : BaseEntity
    {
        public int SchoolYearId { get; set; }
        public int TermNumber { get; set; }

        public string NameEn { get; set; } // First, Second
        public string NameAr { get; set; } // الأول، الثاني

        //public TermType TermType { get; set; }  // enum

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SchoolYear SchoolYear { get; set; }
        public ICollection<SubjectClass> SubjectClasses { get; set; } = new List<SubjectClass>();
    }
}
