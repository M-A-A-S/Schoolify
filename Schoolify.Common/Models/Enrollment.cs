using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    //public class StudentYearLevel : BaseEntity
    public class Enrollment : BaseEntity
    {
        public int StudentId { get; set; }
        public int YearLevelId { get; set; }
        public int SchoolYearId { get; set; }
        public int SectionId { get; set; }

        // Financial
        public decimal TotalFees { get; set; }
        public decimal Discount { get; set; }
        public decimal NetFees { get; set; }

        public EnrollmentStatus Status { get; set; }
        //public decimal? FinalYearScore { get; set; }

        public Student Student { get; set; }
        public YearLevel YearLevel { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public Section Section { get; set; }

        public ICollection<Installment> Installments { get; set; }

        public StudentAcademicRecord StudentAcademicRecord { get; set; }
    }
}
