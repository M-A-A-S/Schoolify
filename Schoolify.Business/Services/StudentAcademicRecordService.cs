using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.StudentAcademicRecord;
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
    public class StudentAcademicRecordService : IStudentAcademicRecordService
    {
        private readonly IStudentAcademicRecordRepository _repo;

        public StudentAcademicRecordService(IStudentAcademicRecordRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<StudentAcademicRecordDTO>> AddAsync(StudentAcademicRecordDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentAcademicRecordDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result, ResultCodes.StudentAcademicRecordCreated);
        }
        #endregion

        #region Get
        public async Task<Result<StudentAcademicRecordDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentAcademicRecordDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync();

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<StudentAcademicRecordDTO>>.Failure(ResultCodes.StudentAcademicRecordsNotFound, 200);
            }

            var result = new List<StudentAcademicRecordDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentAcademicRecordDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<StudentAcademicRecordDTO>> UpdateAsync(int id, StudentAcademicRecordDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentAcademicRecordDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result, ResultCodes.StudentAcademicRecordUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentAcademicRecordDeleted);
        }
        #endregion

    }
}
