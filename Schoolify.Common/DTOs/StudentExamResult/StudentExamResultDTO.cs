using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentExamResult
{
    public class StudentExamResultDTO
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public decimal MarksObtained { get; set; }
        public ExamDTO? Exam { get; set; }
        public StudentDTO? Student { get; set; }
    }
}
