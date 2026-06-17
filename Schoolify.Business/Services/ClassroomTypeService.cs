using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.ClassroomType;
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
    public class ClassroomTypeService : IClassroomTypeService
    {
        private readonly IClassroomTypeRepository _repo;

        public ClassroomTypeService(IClassroomTypeRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<ClassroomTypeDTO>> AddAsync(ClassroomTypeDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<ClassroomTypeDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<ClassroomTypeDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<ClassroomTypeDTO>.Success(result, ResultCodes.ClassroomTypeCreated);
        }
        #endregion

        #region Get
        public async Task<Result<ClassroomTypeDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ClassroomTypeDTO>.Failure(
                    ResultCodes.ClassroomTypeNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ClassroomTypeDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<ClassroomTypeDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync();

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<ClassroomTypeDTO>>.Failure(ResultCodes.ClassroomTypesNotFound, 200);
            }

            var result = new List<ClassroomTypeDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<ClassroomTypeDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<ClassroomTypeDTO>> UpdateAsync(int id, ClassroomTypeDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<ClassroomTypeDTO>.Failure(
                    ResultCodes.ClassroomTypeNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<ClassroomTypeDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ClassroomTypeDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ClassroomTypeDTO>.Success(result, ResultCodes.ClassroomTypeUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.ClassroomTypeNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.ClassroomTypeDeleted);
        }
        #endregion

    }
}
