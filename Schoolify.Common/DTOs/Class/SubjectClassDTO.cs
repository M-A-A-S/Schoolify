using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.DTOs.SubjectClassTeacher;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.DTOs.Term;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Class
{
    public class SubjectClassDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Subject),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SubjectId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Teacher),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
//        public int TeacherId { get; set; }

//        [Display(Name = nameof(Resources.SharedResource.Term),
//    ResourceType = typeof(Resources.SharedResource)
//)]
//        [Required(
//    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
//    ErrorMessageResourceType = typeof(Resources.SharedResource)
//)]
        public int TermId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Section),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SectionId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NameEn),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameEn { get; set; }


        [Display(Name = nameof(Resources.SharedResource.NameAr),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public string NameAr { get; set; }

        [Display(Name = nameof(Resources.SharedResource.MaxScore),
    ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
    ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
    ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        [Range(0, 100, ErrorMessageResourceName = nameof(Resources.SharedResource.RangeError),
    ErrorMessageResourceType = typeof(Resources.SharedResource))]

        public decimal MaxScore { get; set; } = 100;

        //public TeacherDTO? Teacher { get; set; }
        public SubjectDTO? Subject { get; set; }
        public TermDTO? Term { get; set; }
        public SectionDTO? Section { get; set; }
        public ICollection<SubjectClassTeacherDTO> SubjectClassTeachers { get; set; } = new List<SubjectClassTeacherDTO>();

    }
}
