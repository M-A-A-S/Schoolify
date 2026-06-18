using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Exam : BaseEntity
    {
        public int SubjectClassId { get; set; }
        public string NameEn {  get; set; } // Midterm / Final
        public string NameAr { get; set; } // 
        public decimal MaxScore { get; set; }
        public DateTime Date { get; set; }
        public SubjectClass SubjectClass { get; set; }
        public ICollection<StudentExamResult> StudentExamResults { get; set; } = new List<StudentExamResult>();
    }
}
