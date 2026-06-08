using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class StudentGuardian : BaseEntity
    {
        public int GuardianTypeId { get; set; }
        public int GuardianId { get; set; }
        public int StudentId { get; set; }

        public Student Student { get; set; }
        public GuardianType GuardianType { get; set; }
        public Guardian Guardian { get; set; }
    }
}
