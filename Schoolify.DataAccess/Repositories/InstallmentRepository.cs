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
    internal class InstallmentRepository : Repository<Installment>, IInstallmentRepository
    {
        public InstallmentRepository(AppDbContext context, ILogger<Installment> logger) : base(context, logger)
        {

        }

    }
}
