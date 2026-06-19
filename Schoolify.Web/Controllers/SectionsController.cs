using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Section;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class SectionsController : Controller
    {
        private readonly ISectionService _service;
        private readonly IYearLevelService _yearLevelService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public SectionsController(ISectionService service,
            IStringLocalizer<SharedResource> localizer,
            IYearLevelService yearLevelService)
        {
            _service = service;
            _localizer = localizer;
            _yearLevelService = yearLevelService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllSectionsResult = await _service.GetAllAsync();
            return View(findAllSectionsResult.Data);
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
        public async Task<IActionResult> Create()
        {
            await LoadYearLevels();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SectionDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                await LoadYearLevels();
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(DTO);
            }

            var addResult = await _service.AddAsync(DTO);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(DTO);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Edit(int id)
        {
            var findResult = await _service.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }

            await LoadYearLevels();
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SectionDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                await LoadYearLevels();
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(DTO);
            }

            var updateResult = await _service.UpdateAsync(DTO.Id, DTO);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(DTO);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            var findResult = await _service.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var deleteResult = await _service.DeleteAsync(id);

            if (deleteResult.IsSuccess)
            {
                TempData["Success"] = _localizer[deleteResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[deleteResult.Code].Value;
            return View(deleteResult.Data);
        }
        #endregion

        #region Private Helpers
        private async Task LoadYearLevels()
        {
            var yearLevels = await _yearLevelService.GetAllAsync();

            ViewBag.YearLevels = yearLevels.Data.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar"
                        ? d.NameAr
                        : d.NameEn
            });
        }
        #endregion

    }
}
