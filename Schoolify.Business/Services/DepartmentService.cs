using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Department;
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
    internal class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repo;

        public DepartmentService(IDepartmentRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<DepartmentDTO>> AddAsync(DepartmentDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<DepartmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<DepartmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<DepartmentDTO>.Success(result, ResultCodes.DepartmentCreated);
        }
        #endregion

        #region Get
        public async Task<Result<DepartmentDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<DepartmentDTO>.Failure(
                    ResultCodes.DepartmentNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<DepartmentDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<DepartmentDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync();

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<DepartmentDTO>>.Failure(ResultCodes.DepartmentsNotFound, 200);
            }

            var result = new List<DepartmentDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<DepartmentDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<DepartmentDTO>> UpdateAsync(int id, DepartmentDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<DepartmentDTO>.Failure(
                    ResultCodes.DepartmentNotFound,
                    404,
                    "Department not found");
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<DepartmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<DepartmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<DepartmentDTO>.Success(result, ResultCodes.DepartmentUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.DepartmentNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.DepartmentDeleted);
        }
        #endregion
    }
}
