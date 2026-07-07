using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.StudentGuardian;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class StudentGuardiansController : Controller
    {
        private readonly IStudentGuardianService _service;
        private readonly IStudentService _studentService;
        private readonly IGuardianService _guardianService;
        private readonly IGuardianTypeService _guardianTypeService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public StudentGuardiansController(IStudentGuardianService service,
            IStringLocalizer<SharedResource> localizer,
            IStudentService studentService,
            IGuardianService guardianService,
            IGuardianTypeService guardianTypeService)
        {
            _service = service;
            _localizer = localizer;
            _studentService = studentService;
            _guardianService = guardianService;
            _guardianTypeService = guardianTypeService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllStudentGuardiansResult = await _service.GetAllAsync();
            return View(findAllStudentGuardiansResult.Data);
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
            return View(await BuildStudentGuardianUpsertDTO(new StudentGuardianDTO()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentGuardianUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildStudentGuardianUpsertDTO(DTO.StudentGuardian));
            }

            var addResult = await _service.AddAsync(DTO.StudentGuardian);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
                //return RedirectToAction("Index", "StudentGuardians", new { Id = addResult?.Data?.Id });
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildStudentGuardianUpsertDTO(DTO.StudentGuardian));
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
            return View(await BuildStudentGuardianUpsertDTO(findResult.Data));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentGuardianUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildStudentGuardianUpsertDTO(DTO.StudentGuardian));
            }

            var updateResult = await _service.UpdateAsync(DTO.StudentGuardian.Id, DTO.StudentGuardian);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "StudentGuardians", new { Id = DTO?.StudentGuardian?.Id });
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(await BuildStudentGuardianUpsertDTO(DTO.StudentGuardian));
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
        private async Task<StudentGuardianUpsertDTO> BuildStudentGuardianUpsertDTO(StudentGuardianDTO? studentGuardian)
        {
            var studentsResult = await _studentService.GetAllAsync();
            var guardiansResult = await _guardianService.GetAllAsync();
            var guardianTypesResult = await _guardianTypeService.GetAllAsync();

            //var studentsResult = _studentService.GetAllAsync();
            //var guardiansResult = _guardianService.GetAllAsync();
            //var guardianTypesResult = _guardianTypeService.GetAllAsync();

            //await Task.WhenAll(studentsResult, guardiansResult, guardianTypesResult);


            return new StudentGuardianUpsertDTO
            {
                StudentGuardian = studentGuardian ?? new(),

                Students = studentsResult?.Data?.ToList() ?? new(),
                Guardians = guardiansResult?.Data?.ToList() ?? new(),
                GuardianTypes = guardianTypesResult?.Data?.ToList() ?? new()
            };
        }

        #endregion

    }
}
