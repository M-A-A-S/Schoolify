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
    public class FeeStructureRepository : Repository<FeeStructure>, IFeeStructureRepository
    {
        public FeeStructureRepository(AppDbContext context, ILogger<FeeStructure> logger) : base(context, logger)
        {

        }

    }
}
