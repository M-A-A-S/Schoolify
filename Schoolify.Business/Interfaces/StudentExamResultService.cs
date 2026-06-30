using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Utilities;
using Schoolify.Common.Utilities.ResultCodes;
using Schoolify.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolify.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Schoolify.Business.Interfaces
{
    public class StudentExamResultService : IStudentExamResultService
    {
        private readonly IStudentExamResultRepository _repo;

        public StudentExamResultService(IStudentExamResultRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<StudentExamResultDTO>> AddAsync(StudentExamResultDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentExamResultDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentExamResultDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentExamResultDTO>.Success(result, ResultCodes.StudentExamResultCreated);
        }
        #endregion 

        #region Get
        public async Task<Result<StudentExamResultDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                include: q => q
                .Include(t => t.Exam)
                .Include(x => x.Student)
                .AsNoTrackingWithIdentityResolution()
                .AsSplitQuery());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentExamResultDTO>.Failure(
                    ResultCodes.StudentExamResultNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentExamResultDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentExamResultDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(
                include: q => q
                .Include(t => t.Exam)
                .Include(x => x.Student)
                .AsNoTrackingWithIdentityResolution()
                .AsSplitQuery());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<StudentExamResultDTO>>.Failure(ResultCodes.StudentExamResultsNotFound, 200);
            }

            var result = new List<StudentExamResultDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentExamResultDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<StudentExamResultDTO>> UpdateAsync(int id, StudentExamResultDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentExamResultDTO>.Failure(
                    ResultCodes.StudentExamResultNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentExamResultDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentExamResultDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentExamResultDTO>.Success(result, ResultCodes.StudentExamResultUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentExamResultNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentExamResultDeleted);
        }
        #endregion

    }
}
