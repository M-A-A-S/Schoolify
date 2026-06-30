using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IExamService
    {
        Task<Result<ExamDTO>> AddAsync(ExamDTO dto);
        Task<Result<ExamDTO>> UpdateAsync(int id, ExamDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<ExamDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<ExamDTO>>> GetAllAsync();
        Task<Result<ExamDTO>> GetExamScores(int examId);
        Task<Result<bool>> DeleteExamScoresAsync(int examId);
        Task<Result<ExamDTO>> UpdateExamScoresAsync(int examId, ExamDTO dto);

    }
}
