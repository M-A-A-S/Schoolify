using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IEnrollmentService
    {
        Task<Result<EnrollmentDTO>> AddAsync(EnrollmentDTO dto);
        Task<Result<EnrollmentDTO>> UpdateAsync(int id, EnrollmentDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<EnrollmentDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<EnrollmentDTO>>> GetAllAsync();

    }
}
