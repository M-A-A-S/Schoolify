using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Exam
{
    public class ExamDTO
    {
        public int Id { get; set; }
        public int SubjectClassId { get; set; }
        public string NameEn { get; set; } // Midterm / Final
        public string NameAr { get; set; } // 
        public decimal MaxScore { get; set; }
        public DateTime Date { get; set; }
        public SubjectClassDTO? SubjectClass { get; set; }
        public ICollection<StudentExamResultDTO> StudentExamResults { get; set; } = new List<StudentExamResultDTO>();
    }
}
