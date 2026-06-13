using Schoolify.Common.DTOs.Department;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IDepartmentService
    {
        Task<Result<DepartmentDTO>> AddAsync(DepartmentDTO dto);
        Task<Result<DepartmentDTO>> UpdateAsync(int id, DepartmentDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<DepartmentDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<DepartmentDTO>>> GetAllAsync();
    }
}
