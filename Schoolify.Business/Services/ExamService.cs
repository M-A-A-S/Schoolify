using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.Extensions;
using Schoolify.Common.Utilities;
using Schoolify.Common.Utilities.ResultCodes;
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

        public ExamService(IExamRepository repo)
        {
            _repo = repo;
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
        #endregion

    }
}
