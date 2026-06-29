using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Installment;
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
    public class InstallmentService : IInstallmentService
    {
        private readonly IInstallmentRepository _repo;

        public InstallmentService(IInstallmentRepository repo)
        {
            _repo = repo;
        }

        #region Add
        public async Task<Result<InstallmentDTO>> AddAsync(InstallmentDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<InstallmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<InstallmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<InstallmentDTO>.Success(result, ResultCodes.InstallmentCreated);
        }
        #endregion

        #region Get
        public async Task<Result<InstallmentDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, include: q => q.Include(t => t.Enrollment).AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<InstallmentDTO>.Failure(
                    ResultCodes.InstallmentNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<InstallmentDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<InstallmentDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include: q => q.Include(t => t.Enrollment).AsNoTrackingWithIdentityResolution());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<InstallmentDTO>>.Failure(ResultCodes.InstallmentsNotFound, 200);
            }

            var result = new List<InstallmentDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<InstallmentDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<InstallmentDTO>> UpdateAsync(int id, InstallmentDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<InstallmentDTO>.Failure(
                    ResultCodes.InstallmentNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<InstallmentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<InstallmentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<InstallmentDTO>.Success(result, ResultCodes.InstallmentUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.InstallmentNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.InstallmentDeleted);
        }
        #endregion

    }
}
