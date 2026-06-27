using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.FeeStructure;
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
    public class FeeStructureService : IFeeStructureService
    {
        private readonly IFeeStructureRepository _repo;

        public FeeStructureService(IFeeStructureRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<FeeStructureDTO>> AddAsync(FeeStructureDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<FeeStructureDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<FeeStructureDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<FeeStructureDTO>.Success(result, ResultCodes.FeeStructureCreated);
        }
        #endregion

        #region Get
        public async Task<Result<FeeStructureDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id,
                include: q => q
                .Include(x => x.YearLevel)
                .Include(x => x.SchoolYear)
                .Include(x => x.FeeItems));

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<FeeStructureDTO>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<FeeStructureDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<FeeStructureDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include: q => q
                .Include(x => x.YearLevel)
                .Include(x => x.SchoolYear)
                .Include(x => x.FeeItems));

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<FeeStructureDTO>>.Failure(ResultCodes.FeeStructuresNotFound, 200);
            }

            var result = new List<FeeStructureDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<FeeStructureDTO>>.Success(result);
        }
        
        public async Task<Result<decimal>> GetFeesAsync(int schoolYearId, int yearLevelId)
        {
            var structureResult = await _repo.FindByAsync(x => x.YearLevelId == yearLevelId &&
            x.SchoolYearId == schoolYearId, include: q =>
            q.Include(x => x.FeeItems));

            if (!structureResult.IsSuccess || structureResult.Data == null)
            {
                return Result<decimal>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            return Result<decimal>.Success(structureResult.Data.FeeItems.Sum(x => x.Amount));
        }
        #endregion

        #region Update
        public async Task<Result<FeeStructureDTO>> UpdateAsync(int id, FeeStructureDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<FeeStructureDTO>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<FeeStructureDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<FeeStructureDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<FeeStructureDTO>.Success(result, ResultCodes.FeeStructureUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.FeeStructureDeleted);
        }
        #endregion

    }
}
