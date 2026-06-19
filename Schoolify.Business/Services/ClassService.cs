using Microsoft.EntityFrameworkCore;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Class;
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
    public class ClassService : IClassService
    {
        private readonly ISubjectClassRepository _repo;
        private readonly ISubjectClassTeacherRepository _subjectClassTeacherRepository;

        public ClassService(ISubjectClassRepository repo,
            ISubjectClassTeacherRepository subjectClassTeacherRepository)
        {
            _repo = repo;
            _subjectClassTeacherRepository = subjectClassTeacherRepository;
        }

        #region Add
        public async Task<Result<SubjectClassDTO>> AddAsync(SubjectClassDTO dto)
        {

            //var existingResult = await _repo.FindByAsync(
            //    c => c.SubjectId == dto.SubjectId && 
            //    c.TermId == dto.TermId && 
            //    c.SectionId == dto.SectionId && (c.NameEn == dto.NameEn || c.NameAr == dto.NameAr));
            var existingResult = await _repo.FindByAsync(
                c => c.SubjectId == dto.SubjectId && 
                c.TermId == dto.TermId && 
                c.SectionId == dto.SectionId);

            if (existingResult.IsSuccess)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ClassAlreadyExists,
                    400);
            }

            var entity = dto.ToEntity();

            foreach (var t in dto.SubjectClassTeachers)
            {
                entity.SubjectClassTeachers.Add(new SubjectClassTeacher
                {
                    TeacherId = t.TeacherId,
                    IsMainTeacher = t.IsMainTeacher,
                });
            }

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
    //        var existsResult = await _repo.FindByAsync(
    //c => c.Id != id && 
    //c.SubjectId == dto.SubjectId &&
    //c.TermId == dto.TermId &&
    //c.SectionId == dto.SectionId && (c.NameEn == dto.NameEn || c.NameAr == dto.NameAr));
            var existsResult = await _repo.FindByAsync(
    c => c.Id != id && 
    c.SubjectId == dto.SubjectId &&
    c.TermId == dto.TermId &&
    c.SectionId == dto.SectionId);

            if (existsResult.IsSuccess && existsResult.Data != null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ClassAlreadyExists,
                    400);
            }

            var existingResult = await _repo.FindByAsync(c => c.Id == id,
                include: q => q.Include(x => x.SubjectClassTeachers));
            if (!existingResult.IsSuccess || existingResult.Data == null)
            {
                return Result<SubjectClassDTO>.Failure(
                    ResultCodes.ClassNotFound,
                    404);
            }

            var entity = existingResult.Data;

            // Update scalar properties
            entity.UpdateFromDTO(dto);

            //// Remove existing teachers
            //await _subjectClassTeacherRepository.DeleteRangeAsync(entity.SubjectClassTeachers);

            //// add new teachers
            //entity.SubjectClassTeachers = dto.SubjectClassTeachers
            //    .Select(x => new SubjectClassTeacher
            //    {
            //        TeacherId = x.TeacherId,
            //        IsMainTeacher = x.IsMainTeacher
            //    }).ToList();

            var existingTeacherIds = entity.SubjectClassTeachers
                .Select(t => t.TeacherId).ToList();

            var newTeacherIds = dto.SubjectClassTeachers
                .Select(t => t.TeacherId).ToList();

            var toRemove = entity.SubjectClassTeachers
                .Where(t => !newTeacherIds.Contains(t.TeacherId)).ToList();

            await _subjectClassTeacherRepository.DeleteRangeAsync(toRemove);

            var toAdd = newTeacherIds.Except(existingTeacherIds);

            foreach (var teacherId in toAdd)
            {
                entity.SubjectClassTeachers.Add(new SubjectClassTeacher
                {
                    TeacherId = teacherId,
                    IsMainTeacher = dto.SubjectClassTeachers
                        .FirstOrDefault(t => t.TeacherId == teacherId)?.IsMainTeacher ?? false
                });
            }

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
