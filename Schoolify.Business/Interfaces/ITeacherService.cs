using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ITeacherService
    {
        Task<Result<TeacherDTO>> AddAsync(TeacherDTO dto);
        Task<Result<TeacherDTO>> UpdateAsync(int id, TeacherDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<TeacherDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<TeacherDTO>>> GetAllAsync();
    }
}
