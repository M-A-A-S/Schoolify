using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.SubjectClassTeacher
{
    public class SubjectClassTeacherDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.SubjectClass),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SubjectClassId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Teacher),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int TeacherId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.IsMainTeacher),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public bool IsMainTeacher { get; set; }

        public SubjectClassDTO? SubjectClass { get; set; }
        public TeacherDTO? Teacher { get; set; }
    }
}
