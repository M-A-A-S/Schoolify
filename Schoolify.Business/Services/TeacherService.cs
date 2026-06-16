using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Teacher;
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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repo;

        public TeacherService(ITeacherRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<TeacherDTO>> AddAsync(TeacherDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<TeacherDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<TeacherDTO>.Failure(
                    ResultCodes.TeacherNotFound,
                    404);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<TeacherDTO>.Success(result);
        }
        #endregion

        #region Get
        public async Task<Result<TeacherDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<TeacherDTO>.Failure(
                    ResultCodes.TeacherNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<TeacherDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<TeacherDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync();

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<TeacherDTO>>.Success(new List<TeacherDTO>());
            }

            var result = new List<TeacherDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<TeacherDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<TeacherDTO>> UpdateAsync(int id, TeacherDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<TeacherDTO>.Failure(
                    ResultCodes.TeacherNotFound,
                    404,
                    "Teacher not found");
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<TeacherDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<TeacherDTO>.Failure(
                    ResultCodes.TeacherNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<TeacherDTO>.Success(result);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await GetByIdAsync(id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.TeacherNotFound,
                    404);
            }

            return await _repo.DeleteAndSaveAsync(id);
        }
        #endregion

    }
}
