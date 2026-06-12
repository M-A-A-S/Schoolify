using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IGuardianService
    {
        Task<Result<GuardianDTO>> AddAsync(GuardianDTO dto);
        Task<Result<GuardianDTO>> UpdateAsync(int id, GuardianDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<GuardianDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<GuardianDTO>>> GetAllAsync();
    }
}
