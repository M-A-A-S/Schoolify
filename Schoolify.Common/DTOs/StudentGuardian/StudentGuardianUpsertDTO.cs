using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.DTOs.GuardianType;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentGuardian
{
    public class StudentGuardianUpsertDTO
    {
        public StudentGuardianDTO StudentGuardian { get; set; } = new();

        public List<StudentDTO> Students { get; set; } = new();
        public List<GuardianDTO> Guardians { get; set; } = new();
        public List<GuardianTypeDTO> GuardianTypes { get; set; } = new();
    }
}
