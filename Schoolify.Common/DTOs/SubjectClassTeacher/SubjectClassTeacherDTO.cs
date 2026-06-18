using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.SubjectClassTeacher
{
    public class SubjectClassTeacherDTO
    {
        public int Id { get; set; }
        public int SubjectClassId { get; set; }
        public int TeacherId { get; set; }
        public bool IsMainTeacher { get; set; }

        public SubjectClassDTO? SubjectClass { get; set; }
        public TeacherDTO? Teacher { get; set; }
    }
}
