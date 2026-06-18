using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class FeeItem : BaseEntity
    {
        public int FeeStructureId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal Amount { get; set; }
        public FeeStructure FeeStructure { get; set; }

    }
}
