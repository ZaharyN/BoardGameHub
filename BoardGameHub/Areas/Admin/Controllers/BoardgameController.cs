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

		

		public async Task<IActionResult> ViewAll()
		{
			return View();
		}
	}
}
