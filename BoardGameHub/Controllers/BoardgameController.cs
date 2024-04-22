using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.Pagination;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
	public class BoardgameController : Controller
	{
		private readonly IBoardgameService boardgameService;

		public BoardgameController(IBoardgameService _boardgameService)
		{
			boardgameService = _boardgameService;
		}

		[HttpGet]
		public async Task<IActionResult> Active(int page = 1)
		{
			var allBoardgames = await boardgameService.ActiveAsync();

			int boardgamesCount = allBoardgames.Count();

			int pageSize = 8;
			var pager = new PaginatedList(boardgamesCount, page, pageSize);

			int skipper = (page - 1) * pageSize;

			var boardgamesPerPage = allBoardgames.Skip(skipper).Take(pager.PageSize).ToList();

			ViewBag.Pager = pager;

			return View(boardgamesPerPage);
		}

		[HttpGet]
		public async Task<IActionResult> Upcoming()
		{
			var models = await boardgameService.UpcomingAsync();

			return View(models);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		 {
			if (await boardgameService.ExistsAsync(id) == null)
			{
				return NotFound();
			}

			BoardgameDetailsViewModel model = await boardgameService.DetailsAsync(id);

			return View(model);
		}
	}
}
