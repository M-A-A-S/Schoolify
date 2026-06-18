using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class SchoolYear : BaseEntity
    {
        public string NameEn { get; set; } // e.g., "2025-2026"
        public string NameAr { get; set; } // مثل: "٢٠٢٥-٢٠٢٦"
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public ICollection<Term> Terms { get; set; } = new List<Term>();
        public ICollection<Period> Periods { get; set; } = new List<Period>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();
    }
}
