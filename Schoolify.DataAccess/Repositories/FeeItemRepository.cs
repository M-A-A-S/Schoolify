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
    public class FeeItemRepository : Repository<FeeItem>, IFeeItemRepository
    {
        public FeeItemRepository(AppDbContext context, ILogger<FeeItem> logger) : base(context, logger)
        {

        }

    }
}
