using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Authorization;
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
			BoardgameActiveViewModel[] randomBoardgames
				= await boardgameService.GetRandomBoardgames();

			return View(randomBoardgames);
		}

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public async Task<IActionResult> Error(int statusCode)
		{
			if (statusCode == 404)
			{
				return View("Error404");
			}
            if (statusCode == 500)
            {
                return View("Error500");
            }

            return View();
		}
	}
}
