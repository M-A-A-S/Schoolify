using Microsoft.AspNetCore.Mvc;
using Schoolify.Business.Interfaces;
using Schoolify.Common.DTOs.Teacher;
using System.Threading.Tasks;

namespace Schoolify.Web.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
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
                return View(teacher);
            }

            await _teacherService.AddAsync(teacher);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var teacher = await _teacherService.GetByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TeacherDTO teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            await _teacherService.UpdateAsync(teacher.Id, teacher);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var teacher = await _teacherService.GetByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _teacherService.GetByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher.Data);
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
            return RedirectToAction(nameof(Index));
        }

    }
}
