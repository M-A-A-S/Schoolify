using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Class
{
    public class ClassUpsertDTO
    {
        public ClassDTO Class { get; set; }

        public IEnumerable<SubjectDTO> Subjects { get; set; } = Enumerable.Empty<SubjectDTO>();
        public IEnumerable<TeacherDTO> Teachers { get; set; } = Enumerable.Empty<TeacherDTO>();
        public IEnumerable<TermDTO> Terms { get; set; } = Enumerable.Empty<TermDTO>();


    }
}
