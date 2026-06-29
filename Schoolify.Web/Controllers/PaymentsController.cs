using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Payment;
using Schoolify.Common.Extensions;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IPaymentService _service;
        private readonly IInstallmentService _installmentService;
        //private readonly ISchoolYearService _schoolYearService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public PaymentsController(IPaymentService service,
            IStringLocalizer<SharedResource> localizer,
            IInstallmentService installmentService
            //ISchoolYearService schoolYearService
            )
        {
            _service = service;
            _localizer = localizer;
            _installmentService = installmentService;
            //_schoolYearService = schoolYearService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllPaymentsResult = await _service.GetAllAsync();
            return View(findAllPaymentsResult.Data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var findResult = await _service.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create(int? installmentId)
        {
            //await LoadSchoolYears();
            var dto = new PaymentDTO();
            if (installmentId.HasValue)
            {
                var installmentResult = await _installmentService.GetByIdAsync(installmentId.Value);
                if (!installmentResult.IsSuccess || installmentResult.Data == null)
                {
                    return NotFound();
                }

                dto.Installment = installmentResult.Data;
                dto.InstallmentId = installmentResult.Data.Id;
            }

            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                //await LoadSchoolYears();
                await LoadInstallment(DTO);
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(DTO);
            }

            var addResult = await _service.AddAsync(DTO);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "Installments", new { id = DTO.InstallmentId });
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            await LoadInstallment(DTO);
            return View(DTO);
        }
        #endregion

        #region Update
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var findResult = await _service.GetByIdAsync(id);
        //    if (findResult.Data == null || !findResult.IsSuccess)
        //    {
        //        TempData["Error"] = _localizer[findResult.Code].Value;
        //        return NotFound();
        //    }

        //    await LoadSchoolYears();
        //    return View(findResult.Data);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(PaymentDTO DTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        await LoadSchoolYears();
        //        TempData["Error"] = _localizer["ValidationError"].Value;
        //        return View(DTO);
        //    }

        //    var updateResult = await _service.UpdateAsync(DTO.Id, DTO);
        //    if (updateResult.IsSuccess)
        //    {
        //        TempData["Success"] = _localizer[updateResult.Code].Value;
        //        return RedirectToAction(nameof(Index));
        //    }

        //    TempData["Error"] = _localizer[updateResult.Code].Value;
        //    return View(DTO);
        //}
        #endregion

        #region Delete
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var findResult = await _service.GetByIdAsync(id);
        //    if (findResult.Data == null || !findResult.IsSuccess)
        //    {
        //        TempData["Error"] = _localizer[findResult.Code].Value;
        //        return NotFound();
        //    }
        //    return View(findResult.Data);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{

        //    var deleteResult = await _service.DeleteAsync(id);

        //    if (deleteResult.IsSuccess)
        //    {
        //        TempData["Success"] = _localizer[deleteResult.Code].Value;
        //        return RedirectToAction(nameof(Index));
        //    }

        //    TempData["Error"] = _localizer[deleteResult.Code].Value;
        //    return View(deleteResult.Data);
        //}
        #endregion

        #region Private Helpers
        private async Task LoadInstallment(PaymentDTO dto)
        {
            if (dto.InstallmentId > 0)
            {
                var result = await _installmentService.GetByIdAsync(dto.InstallmentId);

                if (result.IsSuccess)
                {
                    dto.Installment = result.Data;
                }
            }
        }
        #endregion

    }
}
