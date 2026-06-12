using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Business.Services;
using Schoolify.Common;
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
    }
}
