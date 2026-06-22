using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.SubjectClassTeacher;
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
    public class SubjectClassTeacherService : ISubjectClassTeacherService
    {
        private readonly ISubjectClassTeacherRepository _repo;

        public SubjectClassTeacherService(ISubjectClassTeacherRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<SubjectClassTeacherDTO>> AddAsync(SubjectClassTeacherDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<SubjectClassTeacherDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<SubjectClassTeacherDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<SubjectClassTeacherDTO>.Success(result, ResultCodes.SubjectClassTeacherCreated);
        }
        #endregion

        #region Get
        public async Task<Result<SubjectClassTeacherDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectClassTeacherDTO>.Failure(
                    ResultCodes.SubjectClassTeacherNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectClassTeacherDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<SubjectClassTeacherDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync();

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<SubjectClassTeacherDTO>>.Failure(ResultCodes.SubjectClassTeachersNotFound, 200);
            }

            var result = new List<SubjectClassTeacherDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SubjectClassTeacherDTO>>.Success(result);
        }

        public async Task<Result<IEnumerable<SubjectClassTeacherDTO>>> GetAllBySubjectClassAsync(int subjectClassId)
        {
            var getAllResult = await _repo.GetAllAsync(x => x.SubjectClassId == subjectClassId,
                include: q => q.Include(x => x.Teacher));

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<SubjectClassTeacherDTO>>.Failure(ResultCodes.SubjectClassTeachersNotFound, 200);
            }

            var result = new List<SubjectClassTeacherDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SubjectClassTeacherDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<SubjectClassTeacherDTO>> UpdateAsync(int id, SubjectClassTeacherDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SubjectClassTeacherDTO>.Failure(
                    ResultCodes.SubjectClassTeacherNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<SubjectClassTeacherDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectClassTeacherDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectClassTeacherDTO>.Success(result, ResultCodes.SubjectClassTeacherUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.SubjectClassTeacherNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.SubjectClassTeacherDeleted);
        }
        #endregion

    }
}
