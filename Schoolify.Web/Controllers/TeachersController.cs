using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Teacher;
using System.Threading.Tasks;

namespace Schoolify.Web.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public TeachersController(ITeacherService teacherService, IStringLocalizer<SharedResource> localizer)
        {
            _teacherService = teacherService;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllAsync();
            return View(teachers.Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherDTO teacher)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(teacher);
            }

            var addResult = await _teacherService.AddAsync(teacher);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer["TeacherCreatedSuccess"].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer["GenericError"].Value;
            return View(teacher);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var findResult = await _teacherService.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer["GenericError"].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TeacherDTO teacher)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(teacher);
            }

            var updateResult = await _teacherService.UpdateAsync(teacher.Id, teacher);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer["TeacherUpdatedSuccess"].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer["GenericError"].Value;
            return View(teacher);
        }


        public async Task<IActionResult> Details(int id)
        {
            var findResult = await _teacherService.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer["GenericError"].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var findResult = await _teacherService.GetByIdAsync(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer["GenericError"].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _teacherService.GetByIdAsync(id);
            if (teacher != null)
            {
                await _teacherService.DeleteAsync(id);
            }

            var deleteResult = await _teacherService.DeleteAsync(id);

            if (deleteResult.IsSuccess)
            {
                TempData["Success"] = _localizer["TeacherDeletedSuccess"].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer["GenericError"].Value;
            return View(teacher);
        }

    }
}
