using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class ScoreRange : BaseEntity
    {
        public decimal MinScore { get; set; } // e.g., 90.00%
        public decimal MaxScore { get; set; } // e.g., 100.00%
        public string Grade { get; set; }     // e.g., "A"
    }
}
