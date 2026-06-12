using Schoolify.Common.DTOs.GuardianType;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IGuardianTypeService
    {
        Task<Result<GuardianTypeDTO>> AddAsync(GuardianTypeDTO dto);
        Task<Result<GuardianTypeDTO>> UpdateAsync(int id, GuardianTypeDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<GuardianTypeDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<GuardianTypeDTO>>> GetAllAsync();
    }
}
