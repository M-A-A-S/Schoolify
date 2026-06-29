using Schoolify.Common.DTOs.Installment;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IInstallmentService
    {
        Task<Result<InstallmentDTO>> AddAsync(InstallmentDTO dto);
        Task<Result<InstallmentDTO>> UpdateAsync(int id, InstallmentDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<InstallmentDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<InstallmentDTO>>> GetAllAsync();

    }
}
