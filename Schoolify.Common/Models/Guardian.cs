using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Guardian : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string ForthName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<StudentGuardian> StudentGuardians { get; set; }
    }
}
