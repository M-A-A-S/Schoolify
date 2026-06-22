using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.ClassSchedule;
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
    public class ClassScheduleService : IClassScheduleService
    {
        private readonly IClassScheduleRepository _repo;
        private readonly IPeriodRepository _periodRepository;
        private readonly ISectionRepository _sectionRepository;

        public ClassScheduleService(IClassScheduleRepository repo,
            IPeriodRepository periodRepository,
            ISectionRepository sectionRepository)
        {
            _repo = repo;
            _periodRepository = periodRepository;
            _sectionRepository = sectionRepository;
        }

        #region Add
        public async Task<Result<ClassScheduleDTO>> AddAsync(ClassScheduleDTO dto)
        {
            var entity = dto.ToEntity();

            var addResult = await _repo.AddAndSaveAsync(entity);

            if (!addResult.IsSuccess)
            {
                return Result<ClassScheduleDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var FindResult = await _repo.FindByAsync(t => t.Id == addResult.Data.Id);

            if (!FindResult.IsSuccess || FindResult.Data == null)
            {
                return Result<ClassScheduleDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = FindResult.Data?.ToDTO();

            return Result<ClassScheduleDTO>.Success(result, ResultCodes.ClassScheduleCreated);
        }
        #endregion

        #region Get
        public async Task<Result<ClassScheduleDTO>> GetByIdAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id, 
                    include: q => q
                        .Include(cs => cs.Period)
                        .Include(cs => cs.Classroom)
                        .Include(cs => cs.SubjectClassTeacher)
                        .AsNoTrackingWithIdentityResolution());

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ClassScheduleDTO>.Failure(
                    ResultCodes.ClassScheduleNotFound,
                    404);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ClassScheduleDTO>.Success(result);
        }

        //public async Task<Result<IEnumerable<ClassScheduleDTO>>> GetAllAsync()
        //{
        //    var getAllResult = await _repo.GetAllAsync(
        //        include: q => q.Include(cs => cs.Period)
        //                .Include(cs => cs.Classroom)
        //                .Include(cs => cs.Class)
        //                .AsNoTrackingWithIdentityResolution());

        //    if (!getAllResult.IsSuccess || getAllResult.Data == null)
        //    {
        //        return Result<IEnumerable<ClassScheduleDTO>>.Failure(ResultCodes.ClassSchedulesNotFound, 200);
        //    }

        //    var result = new List<ClassScheduleDTO>();

        //    foreach (var item in getAllResult.Data)
        //    {
        //        var newItem = item.ToDTO();
        //        result.Add(newItem);
        //    }

        //    return Result<IEnumerable<ClassScheduleDTO>>.Success(result);
        //}

        public async Task<Result<IEnumerable<SectionScheduleDTO>>> GetAllAsync()
        {
            var sectionsResult = await _sectionRepository.GetAllAsync
                (include: q => q
                .Include(s => s.YearLevel)
                .AsNoTrackingWithIdentityResolution());

            if (!sectionsResult.IsSuccess || sectionsResult.Data == null)
            {
                return Result<IEnumerable<SectionScheduleDTO>>
                    .Failure(ResultCodes.SectionsNotFound, 200);
            }

                var getAllSchedulesResult = await _repo.GetAllAsync(
                include: q => q
                        .Include(cs => cs.Period)
                        .Include(cs => cs.Classroom)
                        .Include(cs => cs.SubjectClassTeacher)
                            .ThenInclude(c => c.Teacher)
                        .Include(cs => cs.SubjectClassTeacher)
                            .ThenInclude(c => c.SubjectClass)
                        .AsNoTrackingWithIdentityResolution()
                        .AsSplitQuery());

            if (!getAllSchedulesResult.IsSuccess || getAllSchedulesResult.Data == null)
            {
                return Result<IEnumerable<SectionScheduleDTO>>.Failure(ResultCodes.ClassSchedulesNotFound, 200);
            }

            // load all periods (for table rows)
            var getAllPeriodsResult = await _periodRepository
                    .GetAllAsync(include: q => q.OrderBy(p => p.StartTime));

            if (!getAllPeriodsResult.IsSuccess || getAllPeriodsResult.Data == null)
            {
                return Result<IEnumerable<SectionScheduleDTO>>.Failure(ResultCodes.PeriodsNotFound, 200);
            }

            // get all days of week (columns in timetable)
            var days = Enum.GetValues(typeof(DayOfWeek))
                .Cast<DayOfWeek>()
                .ToList();

            // final result list (one timetable per section)
            var result = new List<SectionScheduleDTO>();

            foreach (var section in sectionsResult.Data)
            {
                //  FILTER schedules for THIS section only
                var sectionSchedules = getAllSchedulesResult.Data
                    .Where(x => x.SectionId == section.Id)
                    .ToList();

                // CREATE GRID
                var grid = new Dictionary<int, Dictionary<DayOfWeek, ScheduleCellDTO>>();

                foreach (var period in getAllPeriodsResult.Data)
                {
                    grid[period.Id] = new Dictionary<DayOfWeek, ScheduleCellDTO>();

                    foreach (var day in days)
                    {
                        // FIND matching schedule
                        var item = sectionSchedules.FirstOrDefault(x =>
                            x.PeriodId == period.Id &&
                            x.DayOfWeek == day);

                        // BUILD CELL
                        grid[period.Id][day] = item == null
                            ? null
                            : new ScheduleCellDTO
                            {
                                ClassScheduleId = item.Id,

                                ClassNameEn = item.SubjectClassTeacher.SubjectClass.NameEn,
                                ClassNameAr = item.SubjectClassTeacher.SubjectClass.NameAr,

                                TeacherName =
                                    $"{item.SubjectClassTeacher.Teacher.FirstName} " +
                                    $"{item.SubjectClassTeacher.Teacher.SecondName} " +
                                    $"{item.SubjectClassTeacher.Teacher.ThirdName} " +
                                    $"{item.SubjectClassTeacher.Teacher.ForthName}",

                                ClassroomNameEn = item.Classroom.NameEn,
                                ClassroomNameAr = item.Classroom.NameAr
                            };
                    }

                }

                // ADD SECTION RESULT
                result.Add(new SectionScheduleDTO
                {
                    SectionId = section.Id,
                    SectionNameEn = section.NameEn,
                    SectionNameAr = section.NameAr,

                    Periods = getAllPeriodsResult.Data
                        .Select(p => p.ToDTO())
                        .ToList(),
                    Days = days,
                    Grid = grid
                });


            }

            return Result<IEnumerable<SectionScheduleDTO>>.Success(result);
        }
        #endregion

        #region Update
        public async Task<Result<ClassScheduleDTO>> UpdateAsync(int id, ClassScheduleDTO dto)
        {

            var existingResult = await _repo.FindByAsync(c => c.Id == id);
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<ClassScheduleDTO>.Failure(
                    ResultCodes.ClassScheduleNotFound,
                    404);
            }

            var entity = existingResult.Data;

            entity.UpdateFromDTO(dto);

            var updateResult = await _repo.UpdateAndSaveAsync(existingResult.Data);

            if (!updateResult.IsSuccess)
            {
                return Result<ClassScheduleDTO>.Failure(ResultCodes.ServerError, 500);
            }

            var findResult = await _repo.FindByAsync(c => c.Id == id);

            if (!findResult.IsSuccess || findResult.Data == null)
            {
                return Result<ClassScheduleDTO>.Failure(
                    ResultCodes.ServerError,
                    500);
            }

            var result = findResult.Data?.ToDTO();

            return Result<ClassScheduleDTO>.Success(result, ResultCodes.ClassScheduleUpdated);

        }
        #endregion

        #region Delete
        public async Task<Result<bool>> DeleteAsync(int id)
        {
            var findResult = await _repo.FindByAsync(c => c.Id == id);
            if (!findResult.IsSuccess)
            {
                return Result<bool>.Failure(
                    ResultCodes.ClassScheduleNotFound,
                    404);
            }

            var deleteResult = await _repo.DeleteAndSaveAsync(findResult.Data);

            if (!deleteResult.IsSuccess)
            {
                return Result<bool>.Failure(ResultCodes.ServerError, 500);
            }

            return Result<bool>.Success(true, ResultCodes.ClassScheduleDeleted);
        }
        #endregion

    }
}
