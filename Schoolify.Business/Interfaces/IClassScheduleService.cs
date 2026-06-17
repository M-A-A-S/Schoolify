using Schoolify.Common.DTOs.ClassSchedule;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IClassScheduleService
    {
        Task<Result<ClassScheduleDTO>> AddAsync(ClassScheduleDTO dto);
        Task<Result<ClassScheduleDTO>> UpdateAsync(int id, ClassScheduleDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ClassScheduleDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<ClassScheduleDTO>>> GetAllAsync();

    }
}
