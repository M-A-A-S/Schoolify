using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class StudentAcademicRecord : BaseEntity
    {
        public int EnrollmentId { get; set; }
        public decimal TotalMarks { get; set; }        // final computed score
        public decimal MaxMarks { get; set; }          // usually 100 or 1000
        public string GradeLetter { get; set; }        // A, B, C...
        public bool IsPassed { get; set; }
        public DateTime CalculatedAt { get; set; } = DateTime.UtcNow;
        public Enrollment Enrollment { get; set; }
    }
}
