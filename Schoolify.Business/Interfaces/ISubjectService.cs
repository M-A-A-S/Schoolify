using Schoolify.Common.DTOs.Subject;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ISubjectService
    {
        Task<Result<SubjectDTO>> AddAsync(SubjectDTO dto);
        Task<Result<SubjectDTO>> UpdateAsync(int id, SubjectDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SubjectDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SubjectDTO>>> GetAllAsync();
    }
}
