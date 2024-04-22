using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryModel;
using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Core.Services
{
    public class CategoryService : ICategoryService
	{
		private readonly BoardGameHubDbContext context;

        public CategoryService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestDifficultyAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay=b.MaximumPlayersAllowedToPlay
				})
				.OrderBy(b => b.Difficulty)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestDifficultyAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.Difficulty)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByCategoryAsync(int id)
		{
			var sorted = await context.Boardgames
				.Where(b => b.BoardgamesCategories
					.Any(bg => bg.CategoryId == id))
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByMinPlayersAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderBy(b => b.MinimumPlayersAllowedToPlay)
					.ThenBy(b => b.MaximumPlayersAllowedToPlay)
				.ToListAsync();

			return sorted;
		}
		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByMaxPlayersAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.MaximumPlayersAllowedToPlay)
					.ThenByDescending(b => b.MinimumPlayersAllowedToPlay)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestPriceAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderBy(b => b.PriceInShop)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestPriceAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.PriceInShop)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestRatingAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderBy(b => b.Rating)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestRatingAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.Rating)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync()
		{
			var sorted = await context.Categories
				.Select(g => new CategoryViewModel()
				{
					Id = g.Id,
					Name = g.Name
				})
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> AllCategoriesBoardgamesAsync()
		{
			IEnumerable<CategoryBoardgameViewModel> models = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					Rating = b.Rating,
					AppropriateAge = b.AppropriateAge,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.ToListAsync();

			return models;
		}
        public async Task<IEnumerable<CategoryBoardgameViewModel>> GetSortedCategories(string sortBy)
		{
			return await BuildCategories().ToListAsync();
		}

        private IQueryable<CategoryBoardgameViewModel> BuildCategories()
        {
			return context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameCategories = b.BoardgamesCategories
						.Select(bg => new CategoryViewModel()
						{
							Id = bg.CategoryId,
							Name = bg.Category.Name
						})
						.ToList(),
					PriceInShop = b.PriceInShop,
					AppropriateAge = b.AppropriateAge,
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				});
        }
    }
}
