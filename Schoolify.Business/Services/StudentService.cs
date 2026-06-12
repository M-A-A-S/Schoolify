using Schoolify.Common.DTOs.Student;
using Schoolify.Common.Extensions;
using Schoolify.Common.Utilities;
using Schoolify.DataAccess.Interfaces;
using Schoolify.Common.Utilities.ResultCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolify.Business.Interfaces;

namespace Schoolify.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<StudentDTO>> AddAsync(StudentDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentDTO>.Success(result, ResultCodes.StudentCreated);
        }
        #endregion

        #region Get
        public async Task<Result<StudentDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentDTO>.Failure(
                    ResultCodes.StudentNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentDTO>>> GetAllAsync()
        {
            var teachersResult = await _repo.GetAllAsync();

            if (!teachersResult.IsSuccess || teachersResult.Data == null)
            {
                return Result<IEnumerable<StudentDTO>>.Failure(ResultCodes.StudentsNotFound, 200);
            }

            var result = new List<StudentDTO>();

            foreach (var item in teachersResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<StudentDTO>> UpdateAsync(int id, StudentDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentDTO>.Failure(
                    ResultCodes.StudentNotFound,
                    404,
                    "Student not found");
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentDTO>.Success(result, ResultCodes.StudentUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentDeleted);
        }
        #endregion
    }
}
