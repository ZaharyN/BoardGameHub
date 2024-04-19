using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
	public class BoardgameController : Controller
    {
        private readonly IBoardgameService boardgameService;

        public BoardgameController( IBoardgameService _boardgameService)
        {
            boardgameService = _boardgameService;
        }

        [HttpGet]
        public async Task<IActionResult> Active()
        {
            var models = await boardgameService.ActiveAsync();

            return View(models);
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
