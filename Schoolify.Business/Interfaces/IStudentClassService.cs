using Schoolify.Common.DTOs.StudentClass;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IStudentClassService
    {
        Task<Result<StudentClassDTO>> AddAsync(StudentClassDTO dto);
        Task<Result<StudentClassDTO>> UpdateAsync(int id, StudentClassDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<StudentClassDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<StudentClassDTO>>> GetAllAsync(int subjectClassId);

    }
}
