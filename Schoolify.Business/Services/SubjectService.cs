using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Subject;
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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repo;

        public SubjectService(ISubjectRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<SubjectDTO>> AddAsync(SubjectDTO dto)
        {
            var entity = dto.ToEntity();    

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<SubjectDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<SubjectDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<SubjectDTO>.Success(result, ResultCodes.SubjectCreated);
        }
        #endregion

        #region Get
        public async Task<Result<SubjectDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: q => q.Include(s => s.Department));

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectDTO>.Failure(
                    ResultCodes.SubjectNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<SubjectDTO>>> GetAllAsync()
        {
            var findAllResult = await _repo.GetAllAsync(include: q => q.Include(s => s.Department));

            if (!findAllResult.IsSuccess || findAllResult.Data == null)
            {
                return Result<IEnumerable<SubjectDTO>>.Failure(ResultCodes.SubjectsNotFound);
            }

            var result = new List<SubjectDTO>();

            foreach (var item in findAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<SubjectDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<SubjectDTO>> UpdateAsync(int id, SubjectDTO dto)
        {
            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SubjectDTO>.Failure(
                    ResultCodes.SubjectNotFound,
                    404,
                    "Subject not found");
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<SubjectDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<SubjectDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<SubjectDTO>.Success(result, ResultCodes.SubjectUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.SubjectNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.SubjectDeleted);
        }
        #endregion

    }
}
