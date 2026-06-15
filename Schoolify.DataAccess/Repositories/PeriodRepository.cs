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
    internal class PeriodRepository : Repository<Period>, IPeriodRepository
    {
        public PeriodRepository(AppDbContext context, ILogger<Period> logger) : base(context, logger)
        {

        }

    }
}
