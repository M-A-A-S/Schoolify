using Schoolify.Common.DTOs.Payment;
using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Business.Interfaces
{
    public interface IPaymentService
    {
        Task<Result<PaymentDTO>> AddAsync(PaymentDTO dto);
        Task<Result<PaymentDTO>> UpdateAsync(int id, PaymentDTO dto);
        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<PaymentDTO>> GetByIdAsync(int id);
        Task<Result<IEnumerable<PaymentDTO>>> GetAllAsync();

    }
}
