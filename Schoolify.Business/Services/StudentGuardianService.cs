using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.StudentGuardian;
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
    public class StudentGuardianService : IStudentGuardianService
    {
        private readonly IStudentGuardianRepository _repo;

        public StudentGuardianService(IStudentGuardianRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<StudentGuardianDTO>> AddAsync(StudentGuardianDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentGuardianDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentGuardianDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentGuardianDTO>.Success(result, ResultCodes.StudentGuardianCreated);
        }
        #endregion

        #region Get
        public async Task<Result<StudentGuardianDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id,
                include: q => q.Include(t => t.Student)
                    .Include(x => x.Guardian)
                    .Include(x => x.GuardianType)
                    .AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentGuardianDTO>.Failure(
                    ResultCodes.StudentGuardianNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentGuardianDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentGuardianDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(
                include: q => q.Include(t => t.Student)
                    .Include(x => x.Guardian)
                    .Include(x => x.GuardianType)
                    .AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<StudentGuardianDTO>>.Failure(ResultCodes.StudentGuardiansNotFound, 200);
            }

            var result = new List<StudentGuardianDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentGuardianDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<StudentGuardianDTO>> UpdateAsync(int id, StudentGuardianDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentGuardianDTO>.Failure(
                    ResultCodes.StudentGuardianNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentGuardianDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentGuardianDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentGuardianDTO>.Success(result, ResultCodes.StudentGuardianUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentGuardianNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentGuardianDeleted);
        }
        #endregion

    }
}
