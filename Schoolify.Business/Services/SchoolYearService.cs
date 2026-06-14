using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.SchoolYear;
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
    public class SchoolYearService : ISchoolYearService
    {
        private readonly ISchoolYearRepository _repo;

        public SchoolYearService(ISchoolYearRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<SchoolYearDTO>> AddAsync(SchoolYearDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<SchoolYearDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<SchoolYearDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<SchoolYearDTO>.Success(result, ResultCodes.SchoolYearCreated);
        }
        #endregion

        #region Get
        public async Task<Result<SchoolYearDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SchoolYearDTO>.Failure(
                    ResultCodes.SchoolYearNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SchoolYearDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<SchoolYearDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync();

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<SchoolYearDTO>>.Failure(ResultCodes.SchoolYearsNotFound, 200);
            }

            var result = new List<SchoolYearDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SchoolYearDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<SchoolYearDTO>> UpdateAsync(int id, SchoolYearDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SchoolYearDTO>.Failure(
                    ResultCodes.SchoolYearNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<SchoolYearDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SchoolYearDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SchoolYearDTO>.Success(result, ResultCodes.SchoolYearUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.SchoolYearNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.SchoolYearDeleted);
        }
        #endregion

    }
}
