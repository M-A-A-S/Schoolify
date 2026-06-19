using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Class;
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
    public class ClassService : IClassService
    {
        private readonly ISubjectClassRepository _repo;

        public ClassService(ISubjectClassRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<SubjectClassDTO>> AddAsync(SubjectClassDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<SubjectClassDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<SubjectClassDTO>.Success(result, ResultCodes.ClassCreated);
        }
        #endregion

        #region Get
        public async Task<Result<SubjectClassDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: 
                q => q.Include(c => c.Subject)
                    .Include(c => c.Term)
                    .Include(c => c.Section)
                    .Include(x => x.SubjectClassTeachers)
                        .ThenInclude(sct => sct.Teacher)
                    //.Include(c => c.Teacher)
                    .AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ClassNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectClassDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<SubjectClassDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include:
                q => q.Include(c => c.Subject)
                    .Include(c => c.Term)
                    .Include(c => c.Section)
                    .Include(x => x.SubjectClassTeachers)
                        .ThenInclude(sct => sct.Teacher)
                    //.Include(c => c.Teacher)
                    .AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<SubjectClassDTO>>.Failure(ResultCodes.ClassesNotFound, 200);
            }

            var result = new List<SubjectClassDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SubjectClassDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<SubjectClassDTO>> UpdateAsync(int id, SubjectClassDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ClassNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<SubjectClassDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectClassDTO>.Success(result, ResultCodes.ClassUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.ClassNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.ClassDeleted);
        }
        #endregion

    }
}
