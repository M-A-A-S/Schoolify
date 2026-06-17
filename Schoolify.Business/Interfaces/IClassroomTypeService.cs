using Schoolify.Common.DTOs.ClassroomType;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IClassroomTypeService
    {
        Task<Result<ClassroomTypeDTO>> AddAsync(ClassroomTypeDTO dto);
        Task<Result<ClassroomTypeDTO>> UpdateAsync(int id, ClassroomTypeDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ClassroomTypeDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<ClassroomTypeDTO>>> GetAllAsync();

    }
}
