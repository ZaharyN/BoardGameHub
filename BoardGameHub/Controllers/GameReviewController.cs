using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.GameReviewViewModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BoardGameHub.Controllers
{
    [Authorize]
    public class GameReviewController : Controller
    {
        private readonly IBoardgameService boardgameService;
        private readonly IGameReviewService gamereviewService;

        public GameReviewController(IBoardgameService _boardgameService,
            IGameReviewService _gamereviewService)
        {
            boardgameService = _boardgameService;
            gamereviewService = _gamereviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            if (await boardgameService.ExistsAsync(id) == null)
            {
                return NotFound();
            }

            string userId = GetUser();
            if (userId == null)
            {
                return BadRequest();
            }

            if (await gamereviewService.UserHasComment(userId, id))
            {
                return BadRequest();
            };

            GameReviewCreateFormModel form = await gamereviewService.GetCreateFormAsync(id);

            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GameReviewCreateFormModel form, int id)
        {

            if (!ModelState.IsValid)
            {
                form.BoardgameId = id;
                return View();
            }

            string userId = GetUser();

            if (userId == null)
            {
                return BadRequest();
            }

            await gamereviewService.CreateAsync(form, id, userId);

            return RedirectToAction("Details", "Boardgame", new { id });
        }

        private string GetUser()
        {
            string userId = string.Empty;

            if (User != null)
            {
                userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return userId;
        }
    }
}
