using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Term;
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
    internal class TermService : ITermService
    {
        private readonly ITermRepository _repo;

        public TermService(ITermRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<TermDTO>> AddAsync(TermDTO dto)
        {
            if (dto.StartDate >= dto.EndDate)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.InvalidDateRange,
                    400);
            }

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<TermDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<TermDTO>.Success(result, ResultCodes.TermCreated);
        }
        #endregion

        #region Get
        public async Task<Result<TermDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: q => q.Include(t => t.SchoolYear).AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.TermNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<TermDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<TermDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include: q => q.Include(t => t.SchoolYear).AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<TermDTO>>.Failure(ResultCodes.TermsNotFound, 200);
            }

            var result = new List<TermDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<TermDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<TermDTO>> UpdateAsync(int id, TermDTO dto)
        {
            if (dto.StartDate >= dto.EndDate)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.InvalidDateRange,
                    400);
            }

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.TermNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<TermDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<TermDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<TermDTO>.Success(result, ResultCodes.TermUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.TermNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.TermDeleted);
        }
        #endregion

    }
}
