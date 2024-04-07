using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryViewModel;
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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

		public async Task<IEnumerable<BoardgameActiveViewModel>> SortByGenreAsync(int id)
		{
			var sorted = await context.Boardgames
				.Where(b => b.BoardgamesGenres
					.Any(bg => bg.GenreId == id))
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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
					BoardgameGenres = b.BoardgamesGenres
						.Select(bg => new BoardgameGenreViewModel()
						{
							Id = bg.GenreId,
							Name = bg.Genre.Name
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

		public async Task<IEnumerable<BoardgameGenreViewModel>> ViewAllGenresAsync()
		{
			var sorted = await context.Genres
				.Select(g => new BoardgameGenreViewModel()
				{
					Id = g.Id,
					Name = g.Name
				})
				.ToListAsync();

			return sorted;
		}

		public async Task<IEnumerable<BoardgameActiveViewModel>> ViewAllGenresBoardgamesAsync()
		{
			IEnumerable<BoardgameActiveViewModel> models = await context.Boardgames
				.AsNoTracking()
				.Select(b => new BoardgameActiveViewModel()
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
