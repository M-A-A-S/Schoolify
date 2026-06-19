using Microsoft.Extensions.Logging;
using Schoolify.Common.Models;
using Schoolify.DataAccess.Data;
using Schoolify.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Repositories
{
    public class SubjectClassTeacherRepository : Repository<SubjectClassTeacher>, ISubjectClassTeacherRepository
    {
        public SubjectClassTeacherRepository(AppDbContext context, ILogger<SubjectClassTeacher> logger) : base(context, logger)
        {

        }

    }
}
