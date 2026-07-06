using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.StudentClass;
using Schoolify.Common.Extensions;
using Schoolify.Common.Utilities;
using Schoolify.Common.Utilities.ResultCodes;
using Schoolify.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Services
{
    public class StudentClassService : IStudentClassService
    {
        private readonly IStudentClassRepository _repo;

        public StudentClassService(IStudentClassRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<StudentClassDTO>> AddAsync(StudentClassDTO dto)
        {
       
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentClassDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentClassDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentClassDTO>.Success(result, ResultCodes.StudentClassCreated);
        }
        #endregion

        #region Get
        public async Task<Result<StudentClassDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                include: q => q.Include(t => t.Student)
                .Include(x => x.SubjectClass)
                .AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentClassDTO>.Failure(
                    ResultCodes.StudentClassNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentClassDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentClassDTO>>> GetAllAsync(int subjectClassId)
        {
            var getAllResult = await _repo.GetAllAsync(predicate: x => x.SubjectClassId == subjectClassId, include: q => q.Include(t => t.Student)
                .Include(x => x.SubjectClass)
                .AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<StudentClassDTO>>.Failure(ResultCodes.StudentClassesNotFound, 200);
            }

            var result = new List<StudentClassDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentClassDTO>>.Success(result);
        }
        
        #endregion

        #region Update
        public async Task<Result<StudentClassDTO>> UpdateAsync(int id, StudentClassDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentClassDTO>.Failure(
                    ResultCodes.StudentClassNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentClassDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentClassDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentClassDTO>.Success(result, ResultCodes.StudentClassUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentClassNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentClassDeleted);
        }
        #endregion

    }
}
