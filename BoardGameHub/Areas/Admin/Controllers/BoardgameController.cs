using BoardGameHub.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class BoardgameController : AdminBaseController
	{
		private readonly IBoardgameService boardgameService;

		public BoardgameController(IBoardgameService _boardgameService)
		{
			boardgameService = _boardgameService;
		}

		[HttpPost]
		public async Task<IActionResult> ChangeGameStatus(int id)
		{
			await boardgameService.PromoteToActiveAsync(id);

			return RedirectToAction("Active", "Boardgame");
		}

		public async Task<IActionResult> ViewAll()
		{
			return View();
		}
	}
}
