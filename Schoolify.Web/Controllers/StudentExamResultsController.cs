using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Schoolify.Business.Interfaces;
using Schoolify.Common;
using Schoolify.Common.DTOs.Exam;
using Schoolify.Common.DTOs.StudentExamResult;
using Schoolify.Common.Models;
using System.Globalization;

namespace Schoolify.Web.Controllers
{
    public class StudentExamResultsController : Controller
    {
        private readonly IStudentExamResultService _service;
        private readonly IExamService _examService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public StudentExamResultsController(IStudentExamResultService service,
            IStringLocalizer<SharedResource> localizer,
            IExamService examService)
        {
            _service = service;
            _localizer = localizer;
            _examService = examService;
        }

        #region Get
        public async Task<IActionResult> Index()
        {
            var findAllExamsResult = await _examService.GetAllAsync();
            return View(findAllExamsResult.Data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var findResult = await _examService.GetExamScores(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create(int? examId)
        {
            if (examId.HasValue)
            {
                var findResult = await _examService.GetExamScores(examId.Value);
                if (findResult.Data == null || !findResult.IsSuccess)
                {
                    TempData["Error"] = _localizer[findResult.Code].Value;
                    return NotFound();
                }
                return View(findResult.Data);
            }

            return NotFound();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(ExamDTO DTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        TempData["Error"] = _localizer["ValidationError"].Value;
        //        return View(DTO);
        //    }

        //    var addResult = await _service.AddAsync(DTO);

        //    if (addResult.IsSuccess)
        //    {
        //        TempData["Success"] = _localizer[addResult.Code].Value;
        //        return RedirectToAction(nameof(Index));
        //    }

        //    TempData["Error"] = _localizer[addResult.Code].Value;
        //    return View(DTO);
        //}
        #endregion

        #region Update
        [HttpGet]
        public async Task<IActionResult> Edit([FromQuery]int examId)
        {
            var findResult = await _examService.GetExamScores(examId);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ExamDTO DTO)
        {
            ModelState.Remove(nameof(ExamDTO.NameEn));
            ModelState.Remove(nameof(ExamDTO.NameAr));

            if (!ModelState.IsValid)
            {
                TempData["Error"] = _localizer["ValidationError"].Value;
                return View(DTO);
            }

            var updateResult = await _examService.UpdateExamScoresAsync(DTO.Id, DTO);
            if (updateResult.IsSuccess)
            {
                TempData["Success"] = _localizer[updateResult.Code].Value;
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "StudentExamResults", new { id = DTO.Id });
            }

            TempData["Error"] = _localizer[updateResult.Code].Value;
            //return View(DTO);
            var findResult = await _examService.GetExamScores(DTO.Id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            var findResult = await _examService.GetExamScores(id);
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

            var deleteResult = await _examService.DeleteExamScoresAsync(id);

            if (deleteResult.IsSuccess)
            {
                TempData["Success"] = _localizer[deleteResult.Code].Value;
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = _localizer[deleteResult.Code].Value;
            //return View(id);
            var findResult = await _examService.GetExamScores(id);
            if (findResult.Data == null || !findResult.IsSuccess)
            {
                TempData["Error"] = _localizer[findResult.Code].Value;
                return NotFound();
            }
            return View(findResult.Data);
        }
        #endregion

        #region Private Helpers
        #endregion

    }
}
