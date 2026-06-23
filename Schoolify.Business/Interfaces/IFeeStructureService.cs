using Schoolify.Common.DTOs.FeeStructure;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IFeeStructureService
    {
        Task<Result<FeeStructureDTO>> AddAsync(FeeStructureDTO dto);
        Task<Result<FeeStructureDTO>> UpdateAsync(int id, FeeStructureDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<FeeStructureDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<FeeStructureDTO>>> GetAllAsync();
        Task<Result<decimal>> GetFeesAsync(int schoolYearId, int yearLevelId);

    }
}
