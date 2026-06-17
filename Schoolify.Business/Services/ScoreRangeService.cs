using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.ScoreRange;
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
    public class ScoreRangeService : IScoreRangeService
    {
        private readonly IScoreRangeRepository _repo;

        public ScoreRangeService(IScoreRangeRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<ScoreRangeDTO>> AddAsync(ScoreRangeDTO dto)
        {

            var overlapResult = await _repo.FindByAsync(c => c.MinScore <= dto.MaxScore && c.MaxScore >= dto.MinScore);

            if (overlapResult.IsSuccess)
            {
                return Result<ScoreRangeDTO>.Failure(ResultCodes.OverlapError, 400);
            }

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<ScoreRangeDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<ScoreRangeDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<ScoreRangeDTO>.Success(result, ResultCodes.ScoreRangeCreated);
        }
        #endregion

        #region Get
        public async Task<Result<ScoreRangeDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ScoreRangeDTO>.Failure(
                    ResultCodes.ScoreRangeNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ScoreRangeDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<ScoreRangeDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync();

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<ScoreRangeDTO>>.Failure(ResultCodes.ScoreRangesNotFound, 200);
            }

            var result = new List<ScoreRangeDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<ScoreRangeDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<ScoreRangeDTO>> UpdateAsync(int id, ScoreRangeDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<ScoreRangeDTO>.Failure(
                    ResultCodes.ScoreRangeNotFound,
                    404);
            }

            var overlapResult = await _repo.FindByAsync(c => c.Id != id && c.MinScore <= dto.MaxScore && c.MaxScore >= dto.MinScore);

            if (overlapResult.IsSuccess)
            {
                return Result<ScoreRangeDTO>.Failure(ResultCodes.OverlapError, 400);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<ScoreRangeDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ScoreRangeDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ScoreRangeDTO>.Success(result, ResultCodes.ScoreRangeUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.ScoreRangeNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.ScoreRangeDeleted);
        }
        #endregion

    }
}
