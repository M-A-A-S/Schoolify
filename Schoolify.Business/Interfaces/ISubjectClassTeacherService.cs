using Schoolify.Common.DTOs.SubjectClassTeacher;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface ISubjectClassTeacherService
    {
        Task<Result<SubjectClassTeacherDTO>> AddAsync(SubjectClassTeacherDTO dto);
        Task<Result<SubjectClassTeacherDTO>> UpdateAsync(int id, SubjectClassTeacherDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<SubjectClassTeacherDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<SubjectClassTeacherDTO>>> GetAllAsync();
        Task<Result<IEnumerable<SubjectClassTeacherDTO>>> GetAllBySubjectClassAsync(int subjectClassId);

    }
}
