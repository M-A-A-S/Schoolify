using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Enrollment;
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
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _repo;

        public EnrollmentService(IEnrollmentRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<EnrollmentDTO>> AddAsync(EnrollmentDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<EnrollmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<EnrollmentDTO>.Success(result, ResultCodes.EnrollmentCreated);
        }
        #endregion

        #region Get
        public async Task<Result<EnrollmentDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                include: q => q.Include(t => t.SchoolYear)
                    .Include(x => x.Student)
                    .Include(x => x.YearLevel)
                    .Include(x => x.Section)
                    .AsNoTrackingWithIdentityResolution()
                    .AsSplitQuery());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.EnrollmentNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<EnrollmentDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<EnrollmentDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(
                include: q => q
                .Include(t => t.SchoolYear)
                .Include(x => x.Student)
                .Include(x => x.YearLevel)
                .Include(x => x.Section)
                .AsNoTrackingWithIdentityResolution()
                .AsSplitQuery());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<EnrollmentDTO>>.Failure(ResultCodes.EnrollmentsNotFound, 200);
            }

            var result = new List<EnrollmentDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<EnrollmentDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<EnrollmentDTO>> UpdateAsync(int id, EnrollmentDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.EnrollmentNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<EnrollmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<EnrollmentDTO>.Success(result, ResultCodes.EnrollmentUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.EnrollmentNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.EnrollmentDeleted);
        }
        #endregion

    }
}
