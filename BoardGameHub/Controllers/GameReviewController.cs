using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.GameReviewViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BoardGameHub.Controllers
{
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

        private string GetUser()
		{
			string userId = string.Empty;

			if (User != null)
			{
				userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			}

			return userId;
		}

		[HttpGet]
		public async Task<IActionResult> GetCreateFormModel(int id)
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

			GameReviewCreateFormModel form = await gamereviewService.GetCreateFormAsync(id);

			return View(form);
		}

		[HttpPost]
        public async Task<IActionResult> Create(GameReviewCreateFormModel form, int id)
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

			await gamereviewService.CreateAsync(form, userId);

			return RedirectToAction("Details","Boardgame", $"id={id}");
		}
    }
}
