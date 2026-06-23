using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Enrollment;

namespace Schoolify.Web.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly IEnrollmentService _service;
        private readonly IStudentService _studentService;
        private readonly IYearLevelService _yearLevelService;
        private readonly ISchoolYearService _schoolYearService;
        private readonly ISectionService _sectionService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public EnrollmentsController(IEnrollmentService service,
            IStringLocalizer<SharedResource> localizer,
            IStudentService studentService,
            IYearLevelService yearLevelService,
            ISchoolYearService schoolYearService,
            ISectionService sectionService)
        {
            _service = service;
            _localizer = localizer;
            _studentService = studentService;
            _yearLevelService = yearLevelService;
            _schoolYearService = schoolYearService;
            _sectionService = sectionService;
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

        [HttpGet]
        public async Task<IActionResult> GetFees(int schoolYearId, int yearLevelId)
        {
            var feeStructure = await _service.GetFeesAsync(schoolYearId, yearLevelId);

            if (!feeStructure.IsSuccess)
            {
                return Json(new { totalFees = 0 });
            }

            return Json(new
            {
                totalFees = feeStructure.Data
            });
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            return View(await BuildViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EnrollmentUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.Enrollment));
            }

            var addResult = await _service.AddAsync(DTO.Enrollment);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildViewModel(DTO.Enrollment));
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
        public async Task<IActionResult> Edit(EnrollmentUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.Enrollment));
            }

            var updateResult = await _service.UpdateAsync(DTO.Enrollment.Id, DTO.Enrollment);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(await BuildViewModel(DTO.Enrollment));
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
        public async Task<EnrollmentUpsertDTO> BuildViewModel(EnrollmentDTO? dto = null)
        {
            var students = await _studentService.GetAllAsync();
            var yearLevels = await _yearLevelService.GetAllAsync();
            var schoolYears = await _schoolYearService.GetAllAsync();
            var sections = await _sectionService.GetAllAsync();

            return new EnrollmentUpsertDTO
            {
                Enrollment = dto ?? new EnrollmentDTO(),
                Students = students.Data ?? [],
                YearLevels = yearLevels.Data ?? [],
                SchoolYears = schoolYears.Data ?? [],
                Sections = sections.Data ?? [],
            };
        }

        #endregion

    }
}
