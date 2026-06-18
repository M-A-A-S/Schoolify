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
    public class SubjectClassRepository : Repository<SubjectClass>, ISubjectClassRepository
    {
        public SubjectClassRepository(AppDbContext context, ILogger<SubjectClass> logger) : base(context, logger)
        {

        }

    }
}
