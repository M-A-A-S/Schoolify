using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Extensions;
using Schoolify.Common.Models;
using Schoolify.Common.Utilities;
using Schoolify.Common.Utilities.ResultCodes;
using Schoolify.DataAccess.Data;
using Schoolify.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Services
{
    internal class ExamService : IExamService
    {
        private readonly IExamRepository _repo;
        private readonly IStudentRepository _studentRepository;
        private readonly IStudentClassRepository _studentClassRepository;
        private readonly IStudentExamResultRepository _studentExamResultRepository;


        public ExamService(IExamRepository repo,
            IStudentRepository studentRepository,
            IStudentClassRepository studentClassRepository,
            IStudentExamResultRepository studentExamResultRepository)
        {
            _repo = repo;
            _studentRepository = studentRepository;
            _studentClassRepository = studentClassRepository;
            _studentExamResultRepository = studentExamResultRepository;
        }

        #region Add
        public async Task<Result<ExamDTO>> AddAsync(ExamDTO dto)
        {
            if (dto.Date < DateTime.Now)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.InvalidDateRange,
                    400);
            }

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<ExamDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<ExamDTO>.Success(result, ResultCodes.ExamCreated);
        }
        #endregion

        #region Get
        public async Task<Result<ExamDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                include: q => q.Include(t => t.SubjectClass).AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.ExamNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ExamDTO>.Success(result);
        }

        public async Task<Result<ExamDTO>> GetExamScores(int examId)
        {
            var examResult = await _repo.FindByAsync(x => x.Id == examId,
                include: q => q
                .Include(x => x.StudentExamResults)
                .AsNoTracking());

            if (!examResult.IsSuccess || examResult.Data == null)
            {
                return Result<ExamDTO>.Failure(ResultCodes.ExamNotFound);
            }

            var examData = examResult.Data;

            var studentClassesResult = await _studentClassRepository.GetAllAsync(
                x => x.SubjectClassId == examData.SubjectClassId,
                include: q => q
                .Include(x => x.Student)
                .AsNoTracking()
                .AsSplitQuery());


            if (!studentClassesResult.IsSuccess || studentClassesResult.Data == null)
            {
                return Result<ExamDTO>.Failure(ResultCodes.StudentClassesNotFound);
            }

            var resultsDictionary = (examData.StudentExamResults ?? new List<StudentExamResult>())
                .ToDictionary(x => x.StudentId);

            var exam = new ExamDTO
            {
                Id = examResult.Data.Id,
                NameEn = examResult.Data.NameEn,
                NameAr = examResult.Data.NameAr,
                MaxScore = examResult.Data.MaxScore,
                Date = examResult.Data.Date,

                StudentExamResults = new List<StudentExamResultDTO>()
            };


            foreach (var studentClass in studentClassesResult.Data)
            {
                //var result = examResult.Data.StudentExamResults
                //    .FirstOrDefault(x => x.StudentId == studentClass.StudentId);

                resultsDictionary.TryGetValue(studentClass.StudentId, out var result);

                exam.StudentExamResults.Add(new StudentExamResultDTO
                {
                    Id = result?.Id ?? 0,
                    ExamId = examData.Id,
                    StudentId = studentClass.StudentId,
                    MarksObtained = result?.MarksObtained ?? 0,
                    Student = studentClass.Student.ToDTO(),

                    IsMarked = result != null,
                }); 

            }

            return Result<ExamDTO>.Success(exam);

        }

        public async Task<Result<IEnumerable<ExamDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(
                include: q => q.Include(t => t.SubjectClass).AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<ExamDTO>>.Failure(ResultCodes.ExamsNotFound, 200);
            }

            var result = new List<ExamDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<ExamDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<ExamDTO>> UpdateAsync(int id, ExamDTO dto)
        {
            if (dto.Date < DateTime.Now)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.InvalidDateRange,
                    400);
            }

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.ExamNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<ExamDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ExamDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ExamDTO>.Success(result, ResultCodes.ExamUpdated);

        }
        
        public async Task<Result<ExamDTO>> UpdateExamScoresAsync(int examId, ExamDTO dto)
        {
            var examResult = await _repo.FindByAsync(x => x.Id == examId,
                include: q => q.Include(x => x.StudentExamResults));

            if (!examResult.IsSuccess || examResult.Data == null)
            {
                return Result<ExamDTO>.Failure(ResultCodes.ExamNotFound);
            }

            var existingResults = examResult.Data.StudentExamResults
            .ToDictionary(x => x.StudentId);               

            foreach (var item in dto.StudentExamResults)
            {
                if (existingResults.TryGetValue(item.StudentId, out var score))
                {
                    score.MarksObtained = item.MarksObtained;
                }
                else
                {
                    examResult.Data.StudentExamResults.Add(new StudentExamResult
                    {
                        ExamId = examResult.Data.Id,
                        StudentId = item.StudentId,
                        MarksObtained = item.MarksObtained,
                    });
                }

            }

            var updateScoresResult = await _repo.UpdateAndSaveAsync(examResult.Data);
            if (!updateScoresResult.IsSuccess)
            {
                return Result<ExamDTO>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<ExamDTO>.Success(examResult.Data.ToDTO(), ResultCodes.StudentExamResultsUpdated);

            //return await GetExamScores(examId);

        }
        
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.ExamNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.ExamDeleted);
        }
        
        public async Task<Result<bool>> DeleteExamScoresAsync(int examId)
        {
            var examScoresResult = await _studentExamResultRepository.GetAllAsync(
                x => x.ExamId == examId);

            if (!examScoresResult.IsSuccess || examScoresResult?.Data == null ||
                !examScoresResult.Data.Any())
            {
                return Result<bool>.Failure(ResultCodes.StudentExamResultsNotFound);
            }

            var deleteResult = await _studentExamResultRepository
                .DeleteRangeAndSaveAsync(examScoresResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentExamResultsDeleted);
        }
        #endregion

    }
}
