using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Business.Services;
using Schoolify.Common;
using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.Enrollment;
using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.DTOs.Student;
using Schoolify.Common.DTOs.StudentClass;
using Schoolify.Common.Models;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class StudentClassesController : Controller
    {
        private readonly IStudentClassService _service;
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public StudentClassesController(IStudentClassService service,
            IStringLocalizer<SharedResource> localizer,
            IClassService classService,
            IStudentService studentService)
        {
            _service = service;
            _localizer = localizer;
            _classService = classService;
            _studentService = studentService;
        }

        #region Get
        public async Task<IActionResult> Index([FromQuery]int? subjectClassId)
        {
            await LoadStudentClasses();
            StudentClassListDTO studentClassList = new StudentClassListDTO();


            if (subjectClassId.HasValue)
            {
                studentClassList.SubjectClassId = subjectClassId.Value;

                var findAllResult = await _service.GetAllAsync(subjectClassId.Value);
                if (!findAllResult.IsSuccess || findAllResult.Data is null || !findAllResult.Data.Any())
                {
                    TempData["Error"] = _localizer[findAllResult.Code].Value;
                    return View(studentClassList);
                }

                studentClassList.StudentClasses = findAllResult.Data.ToList();
            }

            return View(studentClassList);
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

        public async Task<IActionResult> GetClassStudents(int subjectClassId)
        {

            StudentClassListDTO studentClassList = new StudentClassListDTO();

            var classStudentsResult = await _service.GetAllAsync(subjectClassId);

            if (!classStudentsResult.IsSuccess 
                || classStudentsResult.Data is null || 
                !classStudentsResult.Data.Any())
            {
                return Json(studentClassList);
            }

            studentClassList.SubjectClassId = subjectClassId;
            studentClassList.StudentClasses = classStudentsResult.Data.ToList();
            return Json(studentClassList);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create([FromQuery] int? subjectClassId)
        {
            var studentClass = new StudentClassDTO();
            if (subjectClassId.HasValue)
            {
                studentClass.SubjectClassId = subjectClassId.Value;
            }

            var dto = await BuildViewModel(studentClass);

            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentClassUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.StudentClass));
            }

            var addResult = await _service.AddAsync(DTO.StudentClass);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "StudentClasses", new { SubjectClassId = DTO.StudentClass.SubjectClassId });
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildViewModel(DTO.StudentClass));
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

            await LoadStudentClasses();
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentClassDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                await LoadStudentClasses();
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
        public async Task<IActionResult> DeleteConfirmed([FromForm] int id, 
            [FromForm] int? subjectClassId)
        {

            var deleteResult = await _service.DeleteAsync(id);

            if (deleteResult.IsSuccess)
            {
                TempData["Success"] = _localizer[deleteResult.Code].Value;

                if (subjectClassId.HasValue)
                {
                    return RedirectToAction("Index", "StudentClasses", new { SubjectClassId = subjectClassId.Value });
                }
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[deleteResult.Code].Value;
            return View(deleteResult.Data);
        }
        #endregion

        #region Private Helpers
        private async Task LoadStudentClasses()
        {
            var subjectClassesResult = await _classService.GetAllAsync();

            ViewBag.SubjectClasses = subjectClassesResult.Data.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar"
                        ? d.NameAr
                        : d.NameEn
            });
        }
        
        private async Task<StudentClassUpsertDTO> BuildViewModel(StudentClassDTO studentClass)
        {
            var subjectClassesResult = await _classService.GetAllAsync();
            var studentsResult = await _studentService.GetAllAsync();

            var viewModel = new StudentClassUpsertDTO
            {
                StudentClass = studentClass ?? new StudentClassDTO(),
                SubjectClasses = subjectClassesResult?.Data?.ToList() ?? new List<SubjectClassDTO>(),
                Students = studentsResult?.Data?.ToList() ?? new List<StudentDTO>()
            };

            return viewModel;
        }
        #endregion

    }
}
