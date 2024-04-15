using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class BoardgameController : AdminBaseController
	{
		private readonly IBoardgameService boardgameService;
		private readonly IWebHostEnvironment webHostEnvironment;

		public BoardgameController(IBoardgameService _boardgameService,
			 IWebHostEnvironment _webHostEnvironment)
		{
			boardgameService = _boardgameService;
			webHostEnvironment = _webHostEnvironment;
		}

		[HttpPost]
		public async Task<IActionResult> ChangeGameStatus(int id)
		{
			await boardgameService.PromoteToActiveAsync(id);

			return RedirectToAction("Active", "Boardgame", new { area = "" });
		}

		public async Task<IActionResult> ViewAll()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Create()
		{
			BoardgameCreateFormModel form = await boardgameService.GetCreateFormAsync();

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromForm]BoardgameCreateFormModel form)
		{
			if (!ModelState.IsValid)
			{
				form.Categories = await boardgameService.AllCategoriesAsync();
				return View(form);
			}

			if (User.IsAdmin() == false)
			{
				return Unauthorized();
			}

			int boardgameId = await boardgameService.CreateAsync(form);

			return RedirectToAction("Details","Boardgame", new { id = boardgameId });
		}
	}
}
