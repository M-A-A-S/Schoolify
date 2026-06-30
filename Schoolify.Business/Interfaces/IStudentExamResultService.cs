using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IStudentExamResultService
    {
        Task<Result<StudentExamResultDTO>> AddAsync(StudentExamResultDTO dto);
        Task<Result<StudentExamResultDTO>> UpdateAsync(int id, StudentExamResultDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<StudentExamResultDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<StudentExamResultDTO>>> GetAllAsync();

    }
}
