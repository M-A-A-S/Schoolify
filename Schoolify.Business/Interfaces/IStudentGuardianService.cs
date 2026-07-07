using Schoolify.Common.DTOs.StudentGuardian;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IStudentGuardianService
    {
        Task<Result<StudentGuardianDTO>> AddAsync(StudentGuardianDTO dto);
        Task<Result<StudentGuardianDTO>> UpdateAsync(int id, StudentGuardianDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<StudentGuardianDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<StudentGuardianDTO>>> GetAllAsync();

    }
}
