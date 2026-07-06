using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.DTOs.SchoolYear;
using Schoolify.Common.DTOs.StudentAcademicRecord;
using Schoolify.Common.Models;
using System.Globalization;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
        public async Task<IActionResult> Index([FromQuery] int? yearLevelId, [FromQuery] int? schoolYearId, [FromQuery] int? sectionId)
        {
            //await LoadDropDowns();
            //var findAllStudentAcademicRecordsResult = await _enrollmentService.GetAllAsync();
            //return View(findAllStudentAcademicRecordsResult.Data);

            var viewModel = await BuildViewModel();

            if (yearLevelId.HasValue)
            {
                viewModel.YearLevelId = yearLevelId.Value;
            }

            if (schoolYearId.HasValue)
            {
                viewModel.SchoolYearId = schoolYearId.Value;
            }

            if (sectionId.HasValue)
            {
                viewModel.SectionId = sectionId.Value;
            }

            return View(viewModel);
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
        public async Task<IActionResult> Edit([FromQuery]int yearLevelId, [FromQuery] int schoolYearId, [FromQuery] int sectionId)
        {

            var enrollmentsResult = await _enrollmentService.GetAllAsync(yearLevelId, schoolYearId, sectionId);

            if (!enrollmentsResult.IsSuccess || enrollmentsResult.Data == null || !enrollmentsResult.Data.Any())
            {
                TempData["Error"] = _localizer[enrollmentsResult.Code].Value;
                return NotFound();
            }

            var result = new StudentAcademicRecordListDTO
            {
                YearLevelId = yearLevelId,
                SchoolYearId = schoolYearId,
                SectionId = sectionId,
                Enrollments = enrollmentsResult.Data.ToList()
            };
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentAcademicRecordListDTO DTO)
        {
            ModelState.Remove(nameof(StudentAcademicRecordDTO.Enrollment));
            ModelState.Remove(nameof(StudentAcademicRecordDTO.GradeLetter));

            if (!ModelState.IsValid)
            {
                await LoadDropDowns();
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(DTO);
                
            }

            var updateResult = await _service.UpdateStudentAcademicRecordsAsync(DTO);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "StudentAcademicRecords", new { yearLevelId = DTO.YearLevelId, schoolYearId = DTO.SchoolYearId, sectionId = DTO.SectionId });
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(DTO);
        }
        #endregion

        #region Delete

        public async Task<IActionResult> DeleteAll([FromQuery] int yearLevelId, [FromQuery] int schoolYearId, [FromQuery] int sectionId)
        {
            var viewModel = await BuildViewModel();
            viewModel.YearLevelId = yearLevelId;
            viewModel.SchoolYearId = schoolYearId;
            viewModel.SectionId = sectionId;
            var enrolmentsResult = await _enrollmentService.GetAllAsync(yearLevelId, schoolYearId, sectionId);
            if (!enrolmentsResult.IsSuccess || enrolmentsResult.Data is null || !enrolmentsResult.Data.Any())
            {
                TempData["Error"] = _localizer[enrolmentsResult.Code].Value;
                return NotFound();
            }

            viewModel.Enrollments = enrolmentsResult?.Data?.ToList();

            return View(viewModel);
        }

        [HttpPost, ActionName("DeleteAll")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromQuery] int yearLevelId, [FromQuery] int schoolYearId, [FromQuery] int sectionId)
        {

            var deleteResult = await _service.DeleteAllAsync(yearLevelId, schoolYearId, sectionId);

            if (deleteResult.IsSuccess)
            {
                TempData["Success"] = _localizer[deleteResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[deleteResult.Code].Value;
            return View(deleteResult.Data);
        }


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
