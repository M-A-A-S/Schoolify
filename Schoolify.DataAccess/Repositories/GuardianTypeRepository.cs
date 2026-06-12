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
    public class GuardianTypeRepository : Repository<GuardianType>, IGuardianTypeRepository
    {
        public GuardianTypeRepository(AppDbContext context, ILogger<GuardianType> logger) : base(context, logger)
        {

        }
    }
}
