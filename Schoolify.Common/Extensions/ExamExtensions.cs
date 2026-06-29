using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ExamExtensions
    {
        public static ExamDTO ToDTO(this Exam entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ExamDTO
            {
                Id = entity.Id,
                SubjectClassId = entity.SubjectClassId,
                NameEn = entity.NameEn,
                NameAr = entity.NameAr,
                MaxScore = entity.MaxScore,
                Date = entity.Date,
                SubjectClass = entity.SubjectClass?.ToDTO()
            };
        }

        public static Exam ToEntity(this ExamDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new Exam
            {
                Id = DTO.Id,
                SubjectClassId = DTO.SubjectClassId,
                NameEn = DTO.NameEn,
                NameAr = DTO.NameAr,
                MaxScore = DTO.MaxScore,
                Date = DTO.Date,
            };
        }

        public static void UpdateFromDTO(this Exam entity, ExamDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.SubjectClassId = DTO.SubjectClassId;
            entity.NameEn = DTO.NameEn;
            entity.NameAr = DTO.NameAr;
            entity.MaxScore = DTO.MaxScore;
            entity.Date = DTO.Date;
        }

    }
}
