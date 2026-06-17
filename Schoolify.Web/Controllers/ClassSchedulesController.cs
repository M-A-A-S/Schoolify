using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Class;
using Schoolify.Common.DTOs.ClassSchedule;
using Schoolify.Common.Models;

namespace Schoolify.Web.Controllers
{
    public class ClassSchedulesController : Controller
    {
        private readonly IClassScheduleService _service;
        private readonly IClassService _classService;
        private readonly IClassroomService _classroomService;
        private readonly IPeriodService _periodService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public ClassSchedulesController(IClassScheduleService service,
            IStringLocalizer<SharedResource> localizer,
            IClassService classService,
            IClassroomService classroomService,
            IPeriodService periodService)
        {
            _service = service;
            _localizer = localizer;
            _classService = classService;
            _classroomService = classroomService;
            _periodService = periodService;
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
        //public async Task<IActionResult> Create()
        //{

        //    return View(await BuildViewModel());
        //}

        public async Task<IActionResult> Create(int? periodId, int? dayId)
        {
            var dto = new ClassScheduleDTO();

            if (periodId.HasValue)
            {
                dto.PeriodId = periodId.Value;
            }

            if (dayId.HasValue)
            {
                dto.DayOfWeek = (DayOfWeek)dayId.Value;
            }

            return View(await BuildViewModel(dto));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClassScheduleUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.ClassSchedule));
            }

            var addResult = await _service.AddAsync(DTO.ClassSchedule);

            if (addResult.IsSuccess)
            {
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[addResult.Code].Value;
            return View(await BuildViewModel(DTO.ClassSchedule));
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
        public async Task<IActionResult> Edit(ClassScheduleUpsertDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(await BuildViewModel(DTO.ClassSchedule));
            }

            var updateResult = await _service.UpdateAsync(DTO.ClassSchedule.Id, DTO.ClassSchedule);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            return View(await BuildViewModel(DTO.ClassSchedule));
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
        public async Task<ClassScheduleUpsertDTO> BuildViewModel(ClassScheduleDTO? dto = null)
        {
            var classes = await _classService.GetAllAsync();
            var classrooms = await _classroomService.GetAllAsync();
            var periods = await _periodService.GetAllAsync();
            var days = new List<DayDTO>
            {
                new DayDTO { Id = 1, Name = _localizer["Monday"] },
                new DayDTO { Id = 2, Name = _localizer["Tuesday"] },
                new DayDTO { Id = 3, Name = _localizer["Wednesday"] },
                new DayDTO { Id = 4, Name = _localizer["Thursday"] },
                new DayDTO { Id = 5, Name = _localizer["Friday"] },
                new DayDTO { Id = 6, Name = _localizer["Saturday"] },
                new DayDTO { Id = 7, Name = _localizer["Sunday"] }
            };

            //ViewBag.Days = new SelectList(days, "Id", "Name", dto?.DayOfWeek);

            return new ClassScheduleUpsertDTO
            {
                ClassSchedule = dto ?? new ClassScheduleDTO(),
                Classes = classes.Data ?? [],
                Classrooms = classrooms.Data ?? [],
                Periods = periods.Data ?? [],
                Days = days
            };
        }

        #endregion

    }
}
