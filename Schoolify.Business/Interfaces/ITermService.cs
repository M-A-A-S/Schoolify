using Schoolify.Common.DTOs.Term;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ITermService
    {
        Task<Result<TermDTO>> AddAsync(TermDTO dto);
        Task<Result<TermDTO>> UpdateAsync(int id, TermDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<TermDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<TermDTO>>> GetAllAsync();

    }
}
