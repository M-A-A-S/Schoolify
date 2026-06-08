using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Term : BaseEntity
    {
        public int SchoolYearId { get; set; }
        public int TermNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SchoolYear SchoolYear { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
