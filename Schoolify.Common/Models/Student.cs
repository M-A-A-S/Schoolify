using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string ForthName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateOnly EnrolmentDate { get; set; }
        public Gender Gender { get; set; }

        public ICollection<StudentGuardian> StudentGuardians { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<StudentYearLevel> StudentYearLevels { get; set; }
    }
}
