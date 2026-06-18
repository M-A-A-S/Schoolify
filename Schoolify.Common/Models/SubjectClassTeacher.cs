using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class SubjectClassTeacher : BaseEntity
    {
        public int SubjectClassId { get; set; }
        public int TeacherId { get; set; }
        // Optional: role (main teacher / assistant)
        public bool IsMainTeacher { get; set; }
        public SubjectClass SubjectClass { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<ClassSchedule> ClassSchedules { get; set; } 
    }
}
