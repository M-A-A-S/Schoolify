using Schoolify.Common.DTOs.ClassSchedule;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ClassScheduleExtensions
    {
        public static ClassScheduleDTO ToDTO(this ClassSchedule entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ClassScheduleDTO
            {
                Id = entity.Id,
                ClassId = entity.ClassId,
                ClassroomId = entity.ClassroomId,
                PeriodId = entity.PeriodId,
                DayOfWeek = entity.DayOfWeek,

                Class = entity?.Class?.ToDTO(),
                Classroom = entity?.Classroom?.ToDTO(),
                Period = entity?.Period?.ToDTO()
            };
        }

        public static ClassSchedule ToEntity(this ClassScheduleDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new ClassSchedule
            {
                Id = DTO.Id,
                ClassId = DTO.ClassId,
                ClassroomId = DTO.ClassroomId,
                PeriodId = DTO.PeriodId,
                DayOfWeek = DTO.DayOfWeek,
            };
        }

        public static void UpdateFromDTO(this ClassSchedule entity, ClassScheduleDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.ClassId = DTO.ClassId;
            entity.ClassroomId = DTO.ClassroomId;
            entity.PeriodId = DTO.PeriodId;
            entity.DayOfWeek = DTO.DayOfWeek;
        }
    
    }
}
