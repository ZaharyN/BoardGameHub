using BoardGameHub.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BoardGameHub.Controllers
{
	public class GameReviewController : Controller
	{
		private readonly IBoardgameService boardgameService;
		private readonly IGameReviewService gamereviewService;

        public GameReviewController(IBoardgameService _boardgameService,
			IGameReviewService _gamereviewService)
        {
            boardgameService = _boardgameService;
			gamereviewService = _gamereviewService;
        }

        private string GetUser()
		{
			string userId = string.Empty;

			if (User != null)
			{
				userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			}

			return userId;
		}

		//public async Task<IActionResult> GetAddFormModel(int id)
		//{
		//	if(await boardgameService.ExistsAsync(id) == null)
		//	{
		//		return NotFound();
		//	}

		//	string userId = GetUser();
		//	if (userId == null)
		//	{
		//		return BadRequest();
		//	}

			
		//}
    }
}
