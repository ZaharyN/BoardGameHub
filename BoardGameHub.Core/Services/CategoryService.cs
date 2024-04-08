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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestDifficultyAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestDifficultyAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByCategoryAsync(int id)
		{
			var sorted = await context.Boardgames
				.Where(b => b.BoardgamesCategories
					.Any(bg => bg.CategoryId == id))
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByMinPlayersAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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
		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByMaxPlayersAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestPriceAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				//.OrderBy(b => b.PriceInShop)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestPriceAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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
					
					Rating = b.Rating,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				//.OrderByDescending(b => b.PriceInShop)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestRatingAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestRatingAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> AllCategoriesBoardgamesAsync()
		{
			IEnumerable<BoardgameActiveViewModel> models = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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
	}
}
