using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Utilities.ResultCodes
{
    public static partial class ResultCodes
    {
        public const string DatabaseError = "DatabaseError";
        public const string ServerError = "ServerError";
        public const string NotFound = "NotFound";
        public const string InvalidDateRange = "InvalidDateRange";
        public const string InvalidTimeRange = "InvalidTimeRange";
        public const string OverlapError = "OverlapError";

        public const string InvalidMaxMarks = "InvalidMaxMarks";
        public const string InvalidData = "InvalidData";
        public const string NumberOfInstallmentsMustBeGreaterThanZero = "NumberOfInstallmentsMustBeGreaterThanZero";
    }
}
