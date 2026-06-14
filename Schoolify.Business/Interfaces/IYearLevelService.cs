using Schoolify.Common.DTOs.YearLevel;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IYearLevelService
    {
        Task<Result<YearLevelDTO>> AddAsync(YearLevelDTO dto);
        Task<Result<YearLevelDTO>> UpdateAsync(int id, YearLevelDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<YearLevelDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<YearLevelDTO>>> GetAllAsync();
    }
}
