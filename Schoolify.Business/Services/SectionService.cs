using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Section;
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
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _repo;

        public SectionService(ISectionRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<SectionDTO>> AddAsync(SectionDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<SectionDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<SectionDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<SectionDTO>.Success(result, ResultCodes.SectionCreated);
        }
        #endregion

        #region Get
        public async Task<Result<SectionDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: q => q.Include(t => t.YearLevel).AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SectionDTO>.Failure(
                    ResultCodes.SectionNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SectionDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<SectionDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include: q => q.Include(t => t.YearLevel).AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<SectionDTO>>.Failure(ResultCodes.SectionsNotFound, 200);
            }

            var result = new List<SectionDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SectionDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<SectionDTO>> UpdateAsync(int id, SectionDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SectionDTO>.Failure(
                    ResultCodes.SectionNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<SectionDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SectionDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SectionDTO>.Success(result, ResultCodes.SectionUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.SectionNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.SectionDeleted);
        }
        #endregion

    }
}
