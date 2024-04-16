using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

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

			return RedirectToAction("Active", "Boardgame", new { area = "" });
		}

		[HttpGet]
		public async Task<IActionResult> Create()
		{
			BoardgameCreateFormModel form = await boardgameService.GetCreateFormAsync();

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromForm] BoardgameCreateFormModel form)
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

			return RedirectToAction("Details", "Boardgame", new { area = "", id = boardgameId });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			Boardgame boardgame = await boardgameService.ExistsAsync(id);

			if (boardgame == null)
			{
				return NotFound();
			}

			BoardgameEditFormModel form = await boardgameService.GetEditFormAsync(boardgame);

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(BoardgameEditFormModel form)
		{
			Boardgame boardgame = await boardgameService.ExistsAsync(form.Id);

			if (boardgame == null)
			{
				return NotFound();
			}

			await boardgameService.EditAsync(form, boardgame);

			return RedirectToAction("Details", "Boardgame", new { area = "", id = form.Id });
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			Boardgame boardgame = await boardgameService.ExistsAsync(id);

			if (boardgame == null)
			{
				return NotFound();
			}

			BoardgameDeleteFormModel model = await boardgameService.GetDeleteFormAsync(boardgame);

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			Boardgame boardgame = await boardgameService.ExistsAsync(id);

			if (boardgame == null)
			{
				return NotFound();
			}

			await boardgameService.DeleteConfirmed(boardgame);

			return RedirectToAction("Active", "Boardgame", new { area = "" });
		}
	}
}
