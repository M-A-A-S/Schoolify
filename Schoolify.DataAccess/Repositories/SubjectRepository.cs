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
    public class SubjectRepository : Repository<Student>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context, ILogger<Student> logger) : base(context, logger)
        {

        }
    }
}
