using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.DTOs.StudentAcademicRecord;
using System.Globalization;
using System.Threading.Tasks;

namespace Schoolify.Web.Controllers
{
    public class StudentAcademicRecordsController : Controller
    {
        private readonly IStudentAcademicRecordService _service;
        private readonly ISchoolYearService _schoolYearService;
        private readonly IYearLevelService _yearLevelService;
        private readonly ISectionService _sectionService;
        private readonly IEnrollmentService _enrollmentService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public StudentAcademicRecordsController(IStudentAcademicRecordService service,
            IStringLocalizer<SharedResource> localizer,
            ISchoolYearService schoolYearService,
            IYearLevelService yearLevelService,
            ISectionService sectionService,
            IEnrollmentService enrollmentService)
        {
            _service = service;
            _localizer = localizer;
            _schoolYearService = schoolYearService;
            _yearLevelService = yearLevelService;
            _sectionService = sectionService;
            _enrollmentService = enrollmentService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            //await LoadDropDowns();
            //var findAllStudentAcademicRecordsResult = await _enrollmentService.GetAllAsync();
            //return View(findAllStudentAcademicRecordsResult.Data);
            return View(await BuildViewModel());
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
        public async Task<IActionResult> GetEnrollments(int yearLevelId, int schoolYearId, int sectionId)
        {
            var enrollmentsResult = await _enrollmentService.GetAllAsync(yearLevelId, schoolYearId, sectionId);
            if (!enrollmentsResult.IsSuccess || enrollmentsResult.Data == null)
            {
                return Json(new List<EnrollmentDTO>());
            }
            return Json(enrollmentsResult.Data);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            await LoadDropDowns();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentAcademicRecordDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                await LoadDropDowns();
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

            await LoadDropDowns();
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentAcademicRecordDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                await LoadDropDowns();
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

        private async Task<StudentAcademicRecordListDTO> BuildViewModel()
        {
            var yearLevelsResult = await _yearLevelService.GetAllAsync();
            var sectionsResult = await _sectionService.GetAllAsync();
            var schoolYearsResult = await _schoolYearService.GetAllAsync();

            return new StudentAcademicRecordListDTO
            {
                SchoolYears = schoolYearsResult?.Data?.ToList() ?? [],
                YearLevels = yearLevelsResult?.Data?.ToList() ?? [],
                Sections = sectionsResult?.Data?.ToList() ?? [],
            };
        }

        private async Task LoadDropDowns()
        {
            await LoadYearLevels();
            await LoadSections();
            await LoadSchoolYears();
        }

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

        private async Task LoadSections()
        {
            var sections = await _sectionService.GetAllAsync();
            ViewBag.Sections = sections.Data.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar"
                        ? d.NameAr
                        : d.NameEn
            });
        }

        private async Task LoadSchoolYears()
        {
            var schoolYears = await _schoolYearService.GetAllAsync();

            ViewBag.SchoolYears = schoolYears.Data.Select(d => new SelectListItem
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
