using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.YearLevel;
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
    public class YearLevelService : IYearLevelService
    {
        private readonly IYearLevelRepository _repo;

        public YearLevelService(IYearLevelRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<YearLevelDTO>> AddAsync(YearLevelDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<YearLevelDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<YearLevelDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<YearLevelDTO>.Success(result, ResultCodes.YearLevelCreated);
        }
        #endregion

        #region Get
        public async Task<Result<YearLevelDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: q => q.Include(yl => yl.SchoolStage).AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<YearLevelDTO>.Failure(
                    ResultCodes.YearLevelNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<YearLevelDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<YearLevelDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync(include: q => q.Include(yl => yl.SchoolStage).AsNoTrackingWithIdentityResolution());

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<YearLevelDTO>>.Failure(ResultCodes.YearLevelsNotFound, 200);
            }

            var result = new List<YearLevelDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<YearLevelDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<YearLevelDTO>> UpdateAsync(int id, YearLevelDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<YearLevelDTO>.Failure(
                    ResultCodes.YearLevelNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<YearLevelDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<YearLevelDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<YearLevelDTO>.Success(result, ResultCodes.YearLevelUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.YearLevelNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.YearLevelDeleted);
        }
        #endregion

    }
}
