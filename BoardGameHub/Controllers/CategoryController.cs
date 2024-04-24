using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.Pagination;
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

		public async Task<IActionResult> All()
		{
			var sorted = await categoryService.AllCategoriesAsync();

			return View(sorted);
		}

		public async Task<IActionResult> AllCategoriesBoardgames(string sortOrder, int page = 1)
		{
			var allCategoriesBoardgames = await categoryService.AllCategoriesBoardgamesAsync();

			switch (sortOrder)
			{
				case "rating_asc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderBy(c => c.Rating);
					break;
				case "rating_desc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderByDescending(c => c.Rating);
					break;
				case "difficulty_asc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderBy(c => c.Difficulty);
					break;
				case "difficulty_desc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderByDescending(c => c.Difficulty);
					break;
				case "price_asc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderBy(c => c.PriceInShop);
					break;
				case "price_desc":
					allCategoriesBoardgames = allCategoriesBoardgames.OrderByDescending(c => c.PriceInShop);
					break;
				case "players_asc":
					allCategoriesBoardgames = allCategoriesBoardgames
						.OrderBy(c => c.MinimumPlayersAllowedToPlay)
						.ThenBy(c => c.MaximumPlayersAllowedToPlay);
					break;
				case "players_desc":
					allCategoriesBoardgames = allCategoriesBoardgames
						.OrderByDescending(c => c.MaximumPlayersAllowedToPlay)
						.ThenByDescending(c => c.MinimumPlayersAllowedToPlay);
					break;
			}

			int boardgamesCount = allCategoriesBoardgames.Count();

			int pageSize = 8;
			var pager = new PaginatedList(boardgamesCount, page, pageSize);
			pager.Sorting = sortOrder;

			int skipper = (page - 1) * pageSize;

			var categoriesPerPage = allCategoriesBoardgames.Skip(skipper).Take(pager.PageSize).ToList();

			ViewBag.Pager = pager;

			return View(categoriesPerPage);
		}

		public async Task<IActionResult> SortByCategory(int id)
		{
			var sorted = await categoryService.SortByCategoryAsync(id);

			return View(sorted);
		}

	}
}
