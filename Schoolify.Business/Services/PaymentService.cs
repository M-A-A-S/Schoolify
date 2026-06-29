using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Payment;
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
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repo;
        private readonly IInstallmentRepository _installmentRepository;

        public PaymentService(IPaymentRepository repo,
            IInstallmentRepository installmentRepository)
        {
            _repo = repo;
            _installmentRepository = installmentRepository;
        }

        #region Add
        public async Task<Result<PaymentDTO>> AddAsync(PaymentDTO dto)
        {
            if (dto.AmountPaid <= 0)
            {
                return Result<PaymentDTO>
                    .Failure(ResultCodes.AmountMustBeGreaterThanZero, 400);
            }

            var installmentResult = await _installmentRepository
                .FindByAsync(x => x.Id == dto.InstallmentId, 
                include: q => q.Include(x => x.Payments));

            if (!installmentResult.IsSuccess || installmentResult.Data == null)
            {
                return Result<PaymentDTO>
                    .Failure(ResultCodes.InstallmentNotFound, 400);
            }

            var installment = installmentResult.Data;

            decimal totalPaid = installment.Payments?.Sum(x => x.AmountPaid) ?? 0;
            decimal remainingAmount = installment.Amount - totalPaid;

            if (dto.AmountPaid > remainingAmount)
            {
                return Result<PaymentDTO>
                    .Failure(ResultCodes.PaymentExceedsRemainingAmount, 400);
            }
                                                                

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<PaymentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<PaymentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<PaymentDTO>.Success(result, ResultCodes.PaymentCreated);
        }
        #endregion

        #region Get
        public async Task<Result<PaymentDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                include: q => q
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.Student)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.Section)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.SchoolYear)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.YearLevel)
                .AsNoTrackingWithIdentityResolution()
                .AsSplitQuery());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<PaymentDTO>.Failure(
                    ResultCodes.PaymentNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<PaymentDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<PaymentDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync(include: q => q
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.Student)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.Section)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.SchoolYear)
                .Include(t => t.Installment)
                    .ThenInclude(x => x.Enrollment)
                        .ThenInclude(x => x.YearLevel)
                .AsNoTrackingWithIdentityResolution()
                .AsSplitQuery());

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<PaymentDTO>>.Failure(ResultCodes.PaymentsNotFound, 200);
            }

            var result = new List<PaymentDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<PaymentDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<PaymentDTO>> UpdateAsync(int id, PaymentDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<PaymentDTO>.Failure(
                    ResultCodes.PaymentNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<PaymentDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<PaymentDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<PaymentDTO>.Success(result, ResultCodes.PaymentUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.PaymentNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.PaymentDeleted);
        }
        #endregion

    }
}
