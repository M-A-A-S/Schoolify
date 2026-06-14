using Schoolify.Common.DTOs.SchoolStage;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ISchoolStageService
    {
        Task<Result<SchoolStageDTO>> AddAsync(SchoolStageDTO dto);
        Task<Result<SchoolStageDTO>> UpdateAsync(int id, SchoolStageDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SchoolStageDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SchoolStageDTO>>> GetAllAsync();
    }
}
