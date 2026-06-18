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
        Task<Result<SubjectClassDTO>> AddAsync(SubjectClassDTO dto);
        Task<Result<SubjectClassDTO>> UpdateAsync(int id, SubjectClassDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SubjectClassDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SubjectClassDTO>>> GetAllAsync();
    }
}
