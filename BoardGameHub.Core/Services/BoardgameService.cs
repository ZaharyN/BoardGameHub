using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Core.Services
{
    public class BoardgameService : IBoardgameService
    {
        private readonly BoardGameHubDbContext context;

        public BoardgameService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<BoardgameActiveViewModel>> ActiveAsync()
        {
            IEnumerable<BoardgameActiveViewModel> models = await context.Boardgames
                .Where(b => b.IsUpcoming == false)
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
                    DetailsImageUrl = b.DetailsImageUrl,
                    MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
                    MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
                })
                .ToListAsync();

            return models;
        }

        public Task CreateAsync(BoardgameCreateViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BoardgameDetailsViewModel> Details(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BoardgameEditViewModel> EditAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(BoardgameEditViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task PromoteToActiveAsync(Boardgame boardgame)
        {
            boardgame.IsUpcoming = false;

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync()
        {
			IEnumerable<BoardgameUpcomingViewModel> models = await context.Boardgames
				.Where(b => b.IsUpcoming == true)
				.AsNoTracking()
				.Select(b => new BoardgameUpcomingViewModel()
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
					DetailsImageUrl = b.DetailsImageUrl,
					MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
					MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
				})
				.ToListAsync();

            return models;
		}
    }
}
