using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.Enums;
using Schoolify.Common.Extensions;
using Schoolify.Common.Models;
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
        private readonly IFeeStructureRepository _feeStructureRepository;
        private readonly IInstallmentRepository _installmentRepository;

        public EnrollmentService(IEnrollmentRepository repo,
            IFeeStructureRepository feeStructureRepository,
            IInstallmentRepository installmentRepository)
        {
            _repo = repo;
            _feeStructureRepository = feeStructureRepository;
            _installmentRepository = installmentRepository;
        }

        #region Add
        public async Task<Result<EnrollmentDTO>> AddAsync(EnrollmentDTO dto)
        {
            // Prevent duplicates
            var existingDuplicatesResult = await _repo.FindByAsync(x =>
                x.StudentId == dto.StudentId &&
                x.SchoolYearId == dto.SchoolYearId);

            if (existingDuplicatesResult.IsSuccess && 
                existingDuplicatesResult.Data != null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.EnrollmentAlreadyExists,
                    409);
            }

            // Get fee structure
            var feeStructureResult = await _feeStructureRepository.FindByAsync(
                x => x.SchoolYearId == dto.SchoolYearId &&
                     x.YearLevelId == dto.YearLevelId,
                include: q => q.Include(f => f.FeeItems)
                    .Include(x => x.SchoolYear));

            if (!feeStructureResult.IsSuccess || 
                feeStructureResult.Data == null)
            {
                return Result<EnrollmentDTO>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            decimal totalFees = feeStructureResult.Data.FeeItems.Sum(x => x.Amount);

            var entity = dto.ToEntity();

            entity.TotalFees = totalFees;
            //entity.NetFees = totalFees - dto.Discount;
            entity.NetFees = Math.Max(totalFees - dto.Discount, 0);


            var installmentsResult = await CreateInstallmentsAsync(
    entity,
    feeStructureResult.Data.SchoolYear,
    dto.NumberOfInstallments);

            if (!installmentsResult.IsSuccess)
            {
                return Result<EnrollmentDTO>.Failure(
                    installmentsResult.Code,
                    installmentsResult.StatusCode,
                    installmentsResult.Message);
            }

            entity.Installments = installmentsResult?.Data;

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

        public async Task<Result<IEnumerable<EnrollmentDTO>>> GetAllAsync(int yearLevelId, int schoolYearId, int sectionId)
        {
            var getAllResult = await _repo.GetAllAsync(
                x => x.YearLevelId == yearLevelId && x.SchoolYearId == schoolYearId && x.SectionId == sectionId,
                include: q => q
                .Include(t => t.SchoolYear)
                .Include(x => x.Student)
                .Include(x => x.YearLevel)
                .Include(x => x.Section)
                .Include(x => x.StudentAcademicRecord)
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

        public async Task<Result<decimal>> GetFeesAsync(int schoolYearId, int yearLevelId)
        {
            var structureResult = await _feeStructureRepository.FindByAsync(x => x.YearLevelId == yearLevelId &&
            x.SchoolYearId == schoolYearId, include: q =>
            q.Include(x => x.FeeItems));

            if (!structureResult.IsSuccess || structureResult.Data == null)
            {
                return Result<decimal>.Failure(
                    ResultCodes.FeeStructureNotFound,
                    404);
            }

            return Result<decimal>.Success(structureResult.Data.FeeItems.Sum(x => x.Amount));
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


        #region Private helper
        private async Task<Result<List<Installment>>> CreateInstallmentsAsync(
    Enrollment enrollment,
    SchoolYear schoolYear,
    int numberOfInstallments)
        {
            if (numberOfInstallments <= 0)
            {
                return Result<List<Installment>>.Failure(
                    ResultCodes.NumberOfInstallmentsMustBeGreaterThanZero,
                    400,
                    "Number of installments must be greater than zero.");
            }

            var installments = new List<Installment>();

            decimal installmentAmount = Math.Round(
                enrollment.NetFees / numberOfInstallments,
                2);

            decimal remainingAmount = enrollment.NetFees;

            if (numberOfInstallments == 1)
            {
                installments.Add(new Installment
                {
                    EnrollmentId = enrollment.Id,
                    InstallmentNumber = 1,
                    Amount = enrollment.NetFees,
                    DueDate = schoolYear.EndDate,
                    Status = InstallmentStatus.Pending
                });
            }
            else
            {
                int totalDays = schoolYear.EndDate.DayNumber - schoolYear.StartDate.DayNumber;

                // Calculate the number of days between each installment.
                // Example:
                // School year = 300 days
                // Installments = 4
                // There are 3 gaps between 4 payment dates.
                // Interval = 300 / (4 - 1) = 100 days.

                double interval = (double)totalDays / (numberOfInstallments - 1);

                for (int i = 0; i < numberOfInstallments; i++)
                {
                    // Last installment takes the remaining balance
                    // to handle decimal rounding differences.
                    decimal amount = (i == numberOfInstallments - 1)
                        ? remainingAmount
                        : installmentAmount;

                    remainingAmount -= amount;

                    // Spread due dates evenly from school year start
                    // until school year end.
                    DateOnly dueDate = schoolYear.StartDate.AddDays(
                        (int)Math.Round(interval * i));

                    installments.Add(new Installment
                    {
                        EnrollmentId = enrollment.Id,
                        InstallmentNumber = i + 1,
                        Amount = amount,
                        DueDate = dueDate,
                        Status = InstallmentStatus.Pending
                    });
                }
            }

            return Result<List<Installment>>.Success(installments, ResultCodes.InstallmentsCreated);
        }
        #endregion
    }
}
