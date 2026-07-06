using Schoolify.Common.DTOs.StudentAcademicRecord;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IStudentAcademicRecordService
    {
        Task<Result<StudentAcademicRecordDTO>> AddAsync(StudentAcademicRecordDTO dto);
        Task<Result<StudentAcademicRecordDTO>> UpdateAsync(int id, StudentAcademicRecordDTO dto);
        Task<Result<bool>> UpdateStudentAcademicRecordsAsync(StudentAcademicRecordListDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<bool>> DeleteAllAsync(int yearLevelId, int schoolYearId, int sectionId);
        Task<Result<StudentAcademicRecordDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<StudentAcademicRecordDTO>>> GetAllAsync();

    }
}
