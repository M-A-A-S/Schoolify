using Schoolify.Common.DTOs.Student;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IStudentService
    {
        Task<Result<StudentDTO>> AddAsync(StudentDTO dto);
        Task<Result<StudentDTO>> UpdateAsync(int id, StudentDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<StudentDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<StudentDTO>>> GetAllAsync();
    }
}
