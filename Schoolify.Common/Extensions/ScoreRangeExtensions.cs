using Schoolify.Common.DTOs.ScoreRange;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Extensions
{
    public static class ScoreRangeExtensions
    {
        public static ScoreRangeDTO ToDTO(this ScoreRange entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ScoreRangeDTO
            {
                Id = entity.Id,
                MinScore = entity.MinScore,
                MaxScore = entity.MaxScore,
                Grade = entity.Grade
            };
        }

        public static ScoreRange ToEntity(this ScoreRangeDTO DTO)
        {
            if (DTO == null)
            {
                return null;
            }

            return new ScoreRange
            {
                Id = DTO.Id,
                MinScore = DTO.MinScore,
                MaxScore = DTO.MaxScore,
                Grade = DTO.Grade
            };
        }

        public static void UpdateFromDTO(this ScoreRange entity, ScoreRangeDTO DTO)
        {

            if (entity == null || DTO == null)
            {
                return;
            }

            entity.MinScore = DTO.MinScore;
            entity.MaxScore = DTO.MaxScore;
            entity.Grade = DTO.Grade;
        }
    
    }
}
