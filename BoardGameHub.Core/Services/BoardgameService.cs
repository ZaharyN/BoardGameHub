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

        public async Task<IEnumerable<BoardgameGenreViewModel>> AllGenresAsync()
        {
            IEnumerable<BoardgameGenreViewModel> genres = await context.Genres
                .Select(g => new BoardgameGenreViewModel()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToListAsync();

            return genres;
        }

        public async Task<int> CreateAsync(BoardgameCreateFormModel model)
        {
            var boardgame =  new Boardgame()
            {
                Id = model.Id,
                Name = model.Name,
                Rating = model.Rating,
                AppropriateAge = model.AppropriateAge,
                AveragePlayingTime = model.AveragePlayingTime,
                Description = model.Description,
                Difficulty = model.Difficulty,
                YearPublished = model.YearPublished,
                PriceInShop = model.PriceInShop,
                MinimumPlayersAllowedToPlay = model.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = model.MaximumPlayersAllowedToPlay,
                IsUpcoming = model.IsUpcoming
            };

            boardgame.BoardgamesGenres.Add(new BoardgameGenre()
            {
                BoardgameId = boardgame.Id,
                GenreId = model.GenreId_1
            });

            if(model.GenreId_2 != null)
            {
                boardgame.BoardgamesGenres.Add(new BoardgameGenre()
                {
                    BoardgameId = boardgame.Id,
                    GenreId = (int)model.GenreId_2
                });
            }

            if(model.GenreId_3 != null)
            {
                boardgame.BoardgamesGenres.Add(new BoardgameGenre()
                {
                    BoardgameId = boardgame.Id,
                    GenreId = (int)model.GenreId_3
                });
            }

            context.Boardgames.Add(boardgame);
            await context.SaveChangesAsync();

            return boardgame.Id;
        }

        public async Task<BoardgameCreateFormModel> CreateAsync()
        {
            BoardgameCreateFormModel model = new BoardgameCreateFormModel()
            {
                Genres =
                    await context.Genres.
                    Select(g => new BoardgameGenreViewModel()
                    {
                        Id = g.Id,
                        Name = g.Name
                    })
                    .ToListAsync()
            };

            return model;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BoardgameDetailsViewModel> DetailsAsync(int id)
        {
            Boardgame boardgame = await ExistsAsync(id);

            BoardgameDetailsViewModel model = new BoardgameDetailsViewModel()
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
                BoardgameGenres = boardgame.BoardgamesGenres
                    .Select(bg => new BoardgameGenreViewModel()
                    {
                        Id = bg.GenreId,
                        Name = bg.Genre.Name
                    })
                    .ToList(),
                Rating = boardgame.Rating,
                AppropriateAge = boardgame.AppropriateAge,
                AveragePlayingTime = boardgame.AveragePlayingTime,
                Description = boardgame.Description,
                Difficulty = boardgame.Difficulty,
                CardImageUrl = boardgame.CardImageUrl,
                DetailsImageUrl = boardgame.DetailsImageUrl,
                YearPublished = boardgame.YearPublished,
                PriceInShop = boardgame.PriceInShop,
                MinimumPlayersAllowedToPlay = boardgame.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = boardgame.MaximumPlayersAllowedToPlay
            };

            return model;
        }

        public Task<BoardgameEditViewModel> EditAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(BoardgameEditViewModel model)
        {
            throw new NotImplementedException();
        }

		public async Task<Boardgame> ExistsAsync(int id)
		{
            return await context.Boardgames.FindAsync(id);
		}

		public async Task PromoteToActiveAsync(int id)
        {
            Boardgame? boardgame = await context.Boardgames.FindAsync(id);

            if (boardgame != null)
            {
                boardgame.IsUpcoming = false;
            }

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
