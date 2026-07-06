using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.StudentAcademicRecord;
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
    public class StudentAcademicRecordService : IStudentAcademicRecordService
    {
        private readonly IStudentAcademicRecordRepository _repo;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IScoreRangeRepository _scoreRangeRepository;


        public StudentAcademicRecordService(IStudentAcademicRecordRepository repo,
            IEnrollmentRepository enrollmentRepository,
            IScoreRangeRepository scoreRangeRepository)
        {
            _repo = repo;
            _enrollmentRepository = enrollmentRepository;
            _scoreRangeRepository = scoreRangeRepository;
        }

        #region Add
        public async Task<Result<StudentAcademicRecordDTO>> AddAsync(StudentAcademicRecordDTO dto)
        {

            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<StudentAcademicRecordDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result, ResultCodes.StudentAcademicRecordCreated);
        }
        #endregion

        #region Get
        public async Task<Result<StudentAcademicRecordDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result);
        }

        public async Task<Result<IEnumerable<StudentAcademicRecordDTO>>> GetAllAsync()
        {
            var getAllResult = await _repo.GetAllAsync();

            if (!getAllResult.IsSuccess || getAllResult.Data == null)
            {
                return Result<IEnumerable<StudentAcademicRecordDTO>>.Failure(ResultCodes.StudentAcademicRecordsNotFound, 200);
            }

            var result = new List<StudentAcademicRecordDTO>();

            foreach (var item in getAllResult.Data)
            {
                var newItem = item.ToDTO();
                result.Add(newItem);
            }

            return Result<IEnumerable<StudentAcademicRecordDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<StudentAcademicRecordDTO>> UpdateAsync(int id, StudentAcademicRecordDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<StudentAcademicRecordDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<StudentAcademicRecordDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<StudentAcademicRecordDTO>.Success(result, ResultCodes.StudentAcademicRecordUpdated);

        }
        
        public async Task<Result<bool>> UpdateStudentAcademicRecordsAsync(StudentAcademicRecordListDTO dto)
        {
            var enrollmentsResult = await _enrollmentRepository
                .GetAllAsync(x => x.YearLevelId == dto.YearLevelId
                    && x.SchoolYearId == dto.SchoolYearId
                    && x.SectionId == dto.SectionId,
                include: q => q
                    .Include(x => x.StudentAcademicRecord)
                    .Include(x => x.SchoolYear)
                    .Include(x => x.YearLevel)
                    .Include(x => x.Section),
                isTracking: true
                );

            if (!enrollmentsResult.IsSuccess 
                || enrollmentsResult.Data == null 
                || !enrollmentsResult.Data.Any())
            {
                return Result<bool>.Failure(ResultCodes.EnrollmentsNotFound);
            }

            var scoreRangesResult = await _scoreRangeRepository.GetAllAsync();

            if (!scoreRangesResult.IsSuccess 
                || scoreRangesResult.Data == null
                || !scoreRangesResult.Data.Any())
            {
                return Result<bool>.Failure(ResultCodes.ScoreRangesNotFound);
            }

            var enrollmentsDictionary = enrollmentsResult.Data.ToDictionary(e => e.StudentId);

            foreach (var record in dto.Enrollments)
            {
                if (record.StudentAcademicRecord == null)
                {
                    continue;
                }

                if (!enrollmentsDictionary.TryGetValue(record.StudentId, out var enrollment))
                {
                    continue;
                }

                if (enrollment.YearLevel == null || enrollment.YearLevel.MaxMarks <= 0)
                {
                    return Result<bool>.Failure(ResultCodes.InvalidMaxMarks);
                }

                var percentage = 
                    ((decimal)record.StudentAcademicRecord.ObtainedMarks / 
                    (decimal)enrollment.YearLevel.MaxMarks) * 100;

                var gradeLetter = scoreRangesResult.Data
                    .FirstOrDefault(sr => percentage >= sr.MinScore && percentage <= sr.MaxScore)?.Grade;

                var academicRecord = enrollment.StudentAcademicRecord ?? new StudentAcademicRecord
                {
                    EnrollmentId = enrollment.Id,
                };

                academicRecord.ObtainedMarks = record.StudentAcademicRecord.ObtainedMarks;
                academicRecord.MaxMarks = enrollment.YearLevel.MaxMarks;
                academicRecord.Percentage = percentage;
                academicRecord.GradeLetter = gradeLetter;
                academicRecord.IsPassed = percentage >= enrollment.YearLevel.PassPercentage;
                academicRecord.CalculatedAt = DateTime.UtcNow;

                enrollment.StudentAcademicRecord = academicRecord;

                //await _enrollmentRepository.UpdateAsync(enrollment);
            }

            var saveResult = await _enrollmentRepository.SaveChangesAsync();

            if (!saveResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentAcademicRecordsUpdated);
        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.StudentAcademicRecordNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentAcademicRecordDeleted);
        }

        public async Task<Result<bool>> DeleteAllAsync(int yearLevelId, int schoolYearId, int sectionId)
        {
            var enrollmentsResult = await _enrollmentRepository
                .GetAllAsync(x => x.YearLevelId == yearLevelId
                    && x.SchoolYearId == schoolYearId
                    && x.SectionId == sectionId,
                include: q => q
                    .Include(x => x.StudentAcademicRecord),
                isTracking: true
                );

            if (!enrollmentsResult.IsSuccess
                || enrollmentsResult.Data == null
                || !enrollmentsResult.Data.Any())
            {
                return Result<bool>.Failure(ResultCodes.EnrollmentsNotFound);
            }

            var studentAcademicRecordsToDelete = enrollmentsResult.Data
                .Where(e => e.StudentAcademicRecord != null)
                .Select(e => e.StudentAcademicRecord)
                .ToList();

            if (!studentAcademicRecordsToDelete.Any())
            {
                return Result<bool>.Failure(ResultCodes.StudentAcademicRecordsNotFound);
            }



            var deleteResult = await _repo.DeleteRangeAndSaveAsync(studentAcademicRecordsToDelete);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.StudentAcademicRecordsDeleted);
        }
        #endregion

    }
}
