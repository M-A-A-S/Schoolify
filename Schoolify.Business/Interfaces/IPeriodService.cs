using Schoolify.Common.DTOs.Period;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IPeriodService
    {
        Task<Result<PeriodDTO>> AddAsync(PeriodDTO dto);
        Task<Result<PeriodDTO>> UpdateAsync(int id, PeriodDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<PeriodDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<PeriodDTO>>> GetAllAsync();
    }
}
