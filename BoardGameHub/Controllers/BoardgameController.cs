using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
    [Authorize]
    public class BoardgameController : Controller
    {
        private readonly IBoardgameService boardgameService;

        public BoardgameController(IBoardgameService _boardgameService)
        {
            boardgameService = _boardgameService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Active()
        {
            var models = await boardgameService.ActiveAsync();

            return View(models);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Upcoming()
        {
            var models = await boardgameService.UpcomingAsync();
            
            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeGameStatus(int id)
        {
            await boardgameService.PromoteToActiveAsync(id);

            return RedirectToAction(nameof(Active));
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            BoardgameCreateViewModel model = await boardgameService.CreateAsync();

            model.Genres = await boardgameService.AllGenresAsync();

            return View(model);
        }

        public async Task<IActionResult> Create(BoardgameCreateViewModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Genres = await boardgameService.AllGenresAsync();
                return View(model);
            }

            int boardgameId = await boardgameService.CreateAsync(model);

            return RedirectToAction(nameof(Details), new {id = boardgameId});   
        }

        public async Task<IActionResult> Details(int id)
        {
            return Ok();
        }
    }
}
