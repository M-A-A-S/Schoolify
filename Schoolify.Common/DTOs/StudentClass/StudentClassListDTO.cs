using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.StudentClass
{
    public class StudentClassListDTO
    {
        [Display(Name = nameof(Resources.SharedResource.Class),
ResourceType = typeof(Resources.SharedResource)
)]
        public int SubjectClassId { get; set; }

        public List<StudentClassDTO> StudentClasses { get; set; } = new List<StudentClassDTO>();

    }
}
