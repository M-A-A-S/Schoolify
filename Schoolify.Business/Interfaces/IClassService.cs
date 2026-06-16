using Schoolify.Common.DTOs.Class;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IClassService
    {
        Task<Result<ClassDTO>> AddAsync(ClassDTO dto);
        Task<Result<ClassDTO>> UpdateAsync(int id, ClassDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ClassDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<ClassDTO>>> GetAllAsync();
    }
}
