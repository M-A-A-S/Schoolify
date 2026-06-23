using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.Section;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.DTOs.YearLevel;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Enrollment
{
    public class EnrollmentDTO
    {
        public int Id { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Student),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int StudentId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.YearLevel),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int YearLevelId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.SchoolYear),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SchoolYearId { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Section),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public int SectionId { get; set; }

        //        [Display(Name = nameof(Resources.SharedResource.FinalYearScore),
        //ResourceType = typeof(Resources.SharedResource)
        //)]
        //public decimal? FinalYearScore { get; set; }


        [Display(Name = nameof(Resources.SharedResource.TotalFees),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal TotalFees { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Discount),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal Discount { get; set; }

        [Display(Name = nameof(Resources.SharedResource.NetFees),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public decimal NetFees { get; set; }

        [Display(Name = nameof(Resources.SharedResource.Status),
ResourceType = typeof(Resources.SharedResource)
)]
        [Required(
ErrorMessageResourceName = nameof(Resources.SharedResource.Required),
ErrorMessageResourceType = typeof(Resources.SharedResource)
)]
        public EnrollmentStatus Status { get; set; }

        public StudentDTO? Student { get; set; }
        public YearLevelDTO? YearLevel { get; set; }
        public SchoolYearDTO? SchoolYear { get; set; }
        public SectionDTO? Section { get; set; }

        //public ICollection<InstallmentDTO> Installments { get; set; }
        //public StudentAcademicRecordDTO StudentAcademicRecord { get; set; }
    }
}
