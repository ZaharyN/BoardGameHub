using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models;
using BoardGameHub.Core.Models.BoardgameViewModels;
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

        public async Task<IActionResult> Index()
        {
            if (User.IsAdmin())
            {
                return RedirectToAction("ViewAll", "Boardgame", new { area = "Admin" });
            }

			BoardgameActiveViewModel[] randomBoardgames
				= await boardgameService.GetRandomBoardgames();

			return View(randomBoardgames);
		}

        public IActionResult Privacy()
        {
            return View();
        }
		
	}
}
