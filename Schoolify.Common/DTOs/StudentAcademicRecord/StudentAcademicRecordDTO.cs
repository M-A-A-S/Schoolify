using Schoolify.Common.DTOs.Enrollment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentAcademicRecord
{
    public class StudentAcademicRecordDTO
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        public decimal ObtainedMarks { get; set; }        // final computed score
        public decimal MaxMarks { get; set; }          // usually 100 or 1000
        public string GradeLetter { get; set; }        // A, B, C...
        public bool IsPassed { get; set; }
        public DateTime CalculatedAt { get; set; } = DateTime.UtcNow;

        public EnrollmentDTO Enrollment { get; set; }

    }
}
