using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class StudentExamResult : BaseEntity
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public decimal MarksObtained { get; set; }
        public Exam Exam { get; set; }
        public Student Student { get; set; }
    }
}
