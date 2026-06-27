using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.FeeStructure;

namespace Schoolify.Web.Controllers
{
    public class FeeStructuresController : Controller
    {
        private readonly IFeeStructureService _service;
        private readonly ISchoolYearService _schoolYearService;
        private readonly IYearLevelService _yearLevelService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public FeeStructuresController(IFeeStructureService service,
            IStringLocalizer<SharedResource> localizer,
            ISchoolYearService schoolYearService,
            IYearLevelService yearLevelService)
        {
            _service = service;
            _localizer = localizer;
            _schoolYearService = schoolYearService;
            _yearLevelService = yearLevelService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllResult = await _service.GetAllAsync();
            return View(findAllResult.Data);
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
            return View(await BuildViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FeeStructureUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.FeeStructure));
            }

            var addResult = await _service.AddAsync(DTO.FeeStructure);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildViewModel(DTO.FeeStructure));
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
            return View(await BuildViewModel(findResult.Data));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FeeStructureUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.FeeStructure));
            }

            var updateResult = await _service.UpdateAsync(DTO.FeeStructure.Id, DTO.FeeStructure);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(await BuildViewModel(DTO.FeeStructure));
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
            //return View(deleteResult.Data);
            return RedirectToAction(nameof(Delete), new { id });
        }
        #endregion

        #region Private Helpers    
        public async Task<FeeStructureUpsertDTO> BuildViewModel(FeeStructureDTO? dto = null)
        {
            var schoolYearsResult = await _schoolYearService.GetAllAsync();
            var yearLevelsResult = await _yearLevelService.GetAllAsync();

            return new FeeStructureUpsertDTO
            {
                FeeStructure = dto ?? new FeeStructureDTO(),
                YearLevels = yearLevelsResult.Data ?? [],
                SchoolYears = schoolYearsResult.Data ?? [],
            };
        }
        #endregion

    }
}
