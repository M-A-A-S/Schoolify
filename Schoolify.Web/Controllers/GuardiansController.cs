using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Business.Services;
using Schoolify.Common;
using Schoolify.Common.DTOs.Guardian;
using Schoolify.Common.DTOs.Teacher;
using System.Threading.Tasks;

namespace Schoolify.Web.Controllers
{
    public class GuardiansController : Controller
    {
        private readonly IGuardianService _service;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public GuardiansController(IGuardianService service, IStringLocalizer<SharedResource> localizer)
        {
            _service = service;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            var findAllGuardiansResult = await _service.GetAllAsync();
            return View(findAllGuardiansResult.Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GuardianDTO guardian)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(guardian);
            }

            var addResult = await _service.AddAsync(guardian);

            if (addResult.IsSuccess)
            {
                //TempData["Success"] = _localizer["TeacherCreatedSuccess"].Value;
                TempData["Success"] = _localizer[addResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer["GenericError"].Value;
            return View(guardian);
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
        public async Task<IActionResult> Edit(GuardianDTO DTO)
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
    }
}
