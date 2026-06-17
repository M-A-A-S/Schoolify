using Schoolify.Common.DTOs.ScoreRange;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IScoreRangeService
    {
        Task<Result<ScoreRangeDTO>> AddAsync(ScoreRangeDTO dto);
        Task<Result<ScoreRangeDTO>> UpdateAsync(int id, ScoreRangeDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ScoreRangeDTO>> GetByIdAsync(int id);
        Task<Result<ScoreRangeDTO>> GetGradeAsync(decimal score);
        Task<Result<IEnumerable<ScoreRangeDTO>>> GetAllAsync();

    }
}
