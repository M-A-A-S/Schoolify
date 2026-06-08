using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class StudentClass : BaseEntity
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public decimal? MarksObtained { get; set; } // The actual grade earned
        public Student Student { get; set; }
        public Class Class { get; set; }
    }
}
