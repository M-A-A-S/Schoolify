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
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context, ILogger<Payment> logger) : base(context, logger)
        {

        }

    }
}
