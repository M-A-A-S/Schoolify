using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentClass
{
    public class StudentClassUpsertDTO
    {
        public StudentClassDTO StudentClass { get; set; }

        public List<StudentDTO> Students { get; set; } = new List<StudentDTO>();
        public List<SubjectClassDTO> SubjectClasses { get; set; } = new List<SubjectClassDTO>();

    }
}
