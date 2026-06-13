using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Subject;
using System.Globalization;
using System.Threading.Tasks;

namespace Schoolify.Web.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly ISubjectService _service;
        private readonly IDepartmentService _departmentService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public SubjectsController(ISubjectService service, IStringLocalizer<SharedResource> localizer, IDepartmentService departmentService)
        {
            _service = service;
            _localizer = localizer;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var findAllSubjectsResult = await _service.GetAllAsync();
            return View(findAllSubjectsResult.Data);
        }

        public async Task<IActionResult> Create()
        {
            await LoadDepartments();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubjectDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                await LoadDepartments();
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

        public async Task<IActionResult> Edit(int id)
        {
            var findResult = await _service.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubjectDTO DTO)
        {
            if (!ModelState.IsValid)
            {
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

        private async Task LoadDepartments()
        {
            var departments = await _departmentService.GetAllAsync();

            ViewBag.Departments = departments.Data.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar"
                        ? d.NameAr
                        : d.NameEn
            });
        }

    }
}
