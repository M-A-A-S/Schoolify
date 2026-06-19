using Schoolify.Common.DTOs.Section;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ISectionService
    {
        Task<Result<SectionDTO>> AddAsync(SectionDTO dto);
        Task<Result<SectionDTO>> UpdateAsync(int id, SectionDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SectionDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SectionDTO>>> GetAllAsync();

    }
}
