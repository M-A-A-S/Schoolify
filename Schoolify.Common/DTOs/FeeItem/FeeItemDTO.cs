using Schoolify.Common.DTOs.FeeStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.FeeItem
{
    public class FeeItemDTO
    {
        public int Id { get; set; }
        public int FeeStructureId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal Amount { get; set; }
        public FeeStructureDTO? FeeStructure { get; set; }

    }
}
