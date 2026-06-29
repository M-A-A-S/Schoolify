using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Installment;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class InstallmentsController : Controller
    {
        private readonly IInstallmentService _service;
        //private readonly IEnrollmentService _enrollmentService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public InstallmentsController(IInstallmentService service,
            IStringLocalizer<SharedResource> localizer
            //IEnrollmentService enrollmentService
            )
        {
            _service = service;
            _localizer = localizer;
            //_enrollmentService = enrollmentService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllInstallmentsResult = await _service.GetAllAsync();
            return View(findAllInstallmentsResult.Data);
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
        //public async Task<IActionResult> Create()
        //{
        //    await LoadSchoolYears();
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(InstallmentDTO DTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        await LoadSchoolYears();
        //        TempData["Error"] = _localizer["ValidationError"].Value;
        //        return View(DTO);
        //    }

        //    var addResult = await _service.AddAsync(DTO);

        //    if (addResult.IsSuccess)
        //    {
        //        TempData["Success"] = _localizer[addResult.Code].Value;
        //        return RedirectToAction(nameof(Index));
        //    }

        //    TempData["Error"] = _localizer[addResult.Code].Value;
        //    return View(DTO);
        //}
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
        //public async Task<IActionResult> Edit(InstallmentDTO DTO)
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
        //private async Task LoadSchoolYears()
        //{
        //    var enrollmentsResult = await _enrollmentService.GetAllAsync();

        //    ViewBag.Enrollment = enrollmentsResult.Data.Select(d => new SelectListItem
        //    {
        //        Value = d.Id.ToString(),
        //        Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar"
        //                ? d.NameAr
        //                : d.NameEn
        //    });
        //}
        #endregion

    }
}
