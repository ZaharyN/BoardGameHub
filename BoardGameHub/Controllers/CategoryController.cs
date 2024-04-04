using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
	public class CategoryController : Controller
	{
		// Filter by: Genre, Rating, Difficulty, Price in shop, Min and max players
		public IActionResult DefaultSort()
		{
			return View();
		}
	}
}
