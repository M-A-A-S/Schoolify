using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ISchoolYearService
    {
        Task<Result<SchoolYearDTO>> AddAsync(SchoolYearDTO dto);
        Task<Result<SchoolYearDTO>> UpdateAsync(int id, SchoolYearDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SchoolYearDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SchoolYearDTO>>> GetAllAsync();
    }
}
