using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Class;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class ClassesController : Controller
    {
        private readonly IClassService _service;
        private readonly ISubjectService _subjectService;
        private readonly ITeacherService _teacherService;
        private readonly ITermService _termService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public ClassesController(IClassService service,
            IStringLocalizer<SharedResource> localizer,
            ISubjectService subjectService,
            ITeacherService teacherService,
            ITermService termService)
        {
            _service = service;
            _localizer = localizer;
            _subjectService = subjectService;
            _teacherService = teacherService;
            _termService = termService;
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
        public async Task<IActionResult> Create(ClassUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.Class));
            }

            var addResult = await _service.AddAsync(DTO.Class);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildViewModel(DTO.Class));
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
        public async Task<IActionResult> Edit(ClassUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.Class));
            }

            var updateResult = await _service.UpdateAsync(DTO.Class.Id, DTO.Class);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(await BuildViewModel(DTO.Class));
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
        public async Task<ClassUpsertDTO> BuildViewModel(SubjectClassDTO? dto = null)
        {
            var subjects = await _subjectService.GetAllAsync();
            var teachers = await _teacherService.GetAllAsync();
            var terms = await _termService.GetAllAsync();

            //await Task.WhenAll(subjects, teachers, terms);

            return new ClassUpsertDTO
            {
                Class = dto ?? new SubjectClassDTO(),
                Subjects = subjects.Data ?? [],
                Teachers = teachers.Data ?? [],
                Terms = terms.Data ?? []
            };
        }

        //public async Task<ClassUpsertDTO> BuildViewModel(ClassDTO? dto = null)
        //{
        //    var subjects = _subjectService.GetAllAsync();
        //    var teachers = _teacherService.GetAllAsync();
        //    var terms = _termService.GetAllAsync();

        //    await Task.WhenAll(subjects, teachers, terms);

        //    return new ClassUpsertDTO
        //    {
        //        Class = dto ?? new ClassDTO(),
        //        Subjects = subjects.Result.Data ?? [],
        //        Teachers = teachers.Result.Data ?? [],
        //        Terms = terms.Result.Data ?? []
        //    };
        //}

        #endregion

    }
}
