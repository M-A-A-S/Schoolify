using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    //public class Class : BaseEntity
    public class SubjectClass : BaseEntity
    {
        public int SubjectId { get; set; }
        //public int TeacherId { get; set; }
        public int TermId { get; set; }
        //public int SectionId { get; set; }

        public string NameEn { get; set; } // e.g., "Math-Grade10-A"
        public string NameAr { get; set; } // مثل: "رياضيات-الصف العاشر-أ"
        public decimal MaxScore { get; set; } // Flexible Max Grade improvement

        public Subject Subject { get; set; }
        //public Teacher Teacher { get; set; }
        public Term Term { get; set; }
        //public Section Section { get; set; }

        public ICollection<SubjectClassTeacher> SubjectClassTeachers { get; set; } = new List<SubjectClassTeacher>();
        public ICollection<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();
        public ICollection<ClassSchedule> ClassSchedules { get; set; } = new List<ClassSchedule>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
