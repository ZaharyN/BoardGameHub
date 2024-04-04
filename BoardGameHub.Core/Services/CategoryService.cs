using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryViewModel;
using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),
					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.Difficulty)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByGenreAsync(int id)
		{
			var sorted = await context.Boardgames
				.Where(b => b.BoardgamesGenres
					.Any(bg => bg.GenreId == id))
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestPriceInShopAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderBy(b => b.PriceInShop)
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestPriceInShopAsync()
		{
			var sorted = await context.Boardgames
				.AsNoTracking()
				.Select(b => new CategoryBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
						})
						.ToList(),

					Rating = b.Rating,
					PriceInShop = b.PriceInShop,
					Difficulty = b.Difficulty,
					CardImageUrl = b.CardImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.OrderByDescending(b => b.Rating)
				.ToListAsync();

			return sorted;
		}
	}
}
