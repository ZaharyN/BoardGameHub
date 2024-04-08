using BoardGameHub.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BoardGameHub.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
			categoryService = _categoryService;
        }

		public async Task<IActionResult> ViewAll()
		{
			var sorted = await categoryService.ViewAllCategoriesAsync();

			return View(sorted);
		}

		public async Task<IActionResult> ViewAllGenresBoardgames()
		{
			var models = await categoryService.ViewAllCategoriesBoardgamesAsync();

			return View(models);
		}

		public async Task<IActionResult> SortByLowestDifficulty()
		{
			var sorted = await categoryService.SortByLowestDifficultyAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByHighestDifficulty()
		{
			var sorted = await categoryService.SortByHighestDifficultyAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByCategory(int id)
		{
			var sorted = await categoryService.SortByCategoryAsync(id);

			return View(sorted);
		}

		public async Task<IActionResult> SortByMinPlayers()
		{
			var sorted = await categoryService.SortByMinPlayersAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByMaxPlayers()
		{
			var sorted = await categoryService.SortByMaxPlayersAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByLowestPrice()
		{
			var sorted = await categoryService.SortByLowestPriceAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByHighestPrice()
		{
			var sorted = await categoryService.SortByHighestPriceAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByLowestRating()
		{
			var sorted = await categoryService.SortByLowestRatingAsync();

			return View(sorted);
		}

		public async Task<IActionResult> SortByHighestRating()
		{
			var sorted = await categoryService.SortByHighestRatingAsync();

			return View(sorted);
		}
	}
}
