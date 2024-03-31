using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
    [Authorize]
    public class BoardgameController : Controller
    {
        private readonly IBoardgameService boardGameService;

        public BoardgameController(IBoardgameService _boardgameService)
        {
            boardGameService = _boardgameService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var models = await boardGameService.AllAsync();

            return View(models);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Upcoming()
        {
            var models = await boardGameService.UpcomingAsync();

            return View(models);
        }
    }
}
