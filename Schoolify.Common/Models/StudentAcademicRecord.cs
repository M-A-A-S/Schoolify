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
        public decimal ObtainedMarks { get; set; }        // final computed score

        // TODO: Move MaxMarks to Enrollment or YearLevel, since it is not specific to a student
        public decimal MaxMarks { get; set; }          // usually 100 or 1000

        public decimal Percentage { get; set; }
        public string GradeLetter { get; set; }        // A, B, C...
        public bool IsPassed { get; set; }
        public DateTime CalculatedAt { get; set; } = DateTime.UtcNow;
        public Enrollment Enrollment { get; set; }
    }
}
