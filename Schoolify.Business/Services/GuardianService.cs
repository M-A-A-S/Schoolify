using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.DTOs.Teacher;
using Schoolify.Common.Extensions;
using Schoolify.Common.Utilities;
using Schoolify.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace Schoolify.Business.Services
{
    public class GuardianService : IGuardianService
    {
        private readonly IGuardianRepository _repo;

        public GuardianService(IGuardianRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<GuardianDTO>> AddAsync(GuardianDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<GuardianDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                //return Result<GuardianDTO>.Failure(
                //    ResultCodes.GuardianNotFound,
                //    404);
                return Result<GuardianDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<GuardianDTO>.Success(result, ResultCodes.GuardianCreated);
        }
        #endregion

        #region Get
        public async Task<Result<GuardianDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<GuardianDTO>.Failure(
                    ResultCodes.GuardianNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<GuardianDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<GuardianDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync();

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<GuardianDTO>>.Failure(ResultCodes.GuardiansNotFound, 200);
            }

            var result = new List<GuardianDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<GuardianDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<GuardianDTO>> UpdateAsync(int id, GuardianDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<GuardianDTO>.Failure(
                    ResultCodes.GuardianNotFound,
                    404,
                    "Guardian not found");
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<GuardianDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<GuardianDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<GuardianDTO>.Success(result, ResultCodes.GuardianUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.GuardianNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.GuardianDeleted);
        }
        #endregion
    }
}
