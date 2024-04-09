using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BoardGameHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBoardgameService boardgameService;

        public HomeController(IBoardgameService _boardgameService)
        {
            boardgameService = _boardgameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomBoardgames()
        {
            IEnumerable<Boardgame> randomBoardgames = 
                await boardgameService.GetRandomBoardgames();

            return View(randomBoardgames);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
		
	}
}
