using Schoolify.Common.DTOs.Classroom;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IClassroomService
    {
        Task<Result<ClassroomDTO>> AddAsync(ClassroomDTO dto);
        Task<Result<ClassroomDTO>> UpdateAsync(int id, ClassroomDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ClassroomDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<ClassroomDTO>>> GetAllAsync();

    }
}
