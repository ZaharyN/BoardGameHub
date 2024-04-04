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
            var boardgame = new Boardgame()
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

            if (model.GenreId_2 != null)
            {
                boardgame.BoardgamesGenres.Add(new BoardgameGenre()
                {
                    BoardgameId = boardgame.Id,
                    GenreId = (int)model.GenreId_2
                });
            }

            if (model.GenreId_3 != null)
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

        public async Task<BoardgameCreateFormModel> GetCreateFormAsync()
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

        public async Task<BoardgameEditFormModel> GetEditFormAsync(Boardgame boardgame)
        {
            BoardgameEditFormModel model = new BoardgameEditFormModel()
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
                Genres = await AllGenresAsync(),
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

            var boardgameGenres = boardgame.BoardgamesGenres.ToList();

            model.GenreId_1 = boardgameGenres[0].GenreId;
            model.GenreId_2 = boardgameGenres[1].GenreId;

            if(boardgameGenres.Count > 2)
            {
                model.GenreId_3 = boardgameGenres[2].GenreId;
            }

            return model;
        }

        public async Task EditAsync(BoardgameEditFormModel model, Boardgame boardgame)
        {
            boardgame.Name = model.Name;
            boardgame.Rating = model.Rating;
            boardgame.AppropriateAge = model.AppropriateAge;
            boardgame.AveragePlayingTime = model.AveragePlayingTime;
            boardgame.Description = model.Description;
            boardgame.Difficulty = model.Difficulty;
            boardgame.CardImageUrl = model.CardImageUrl;
            boardgame.DetailsImageUrl = model.DetailsImageUrl;
            boardgame.YearPublished = model.YearPublished;
            boardgame.PriceInShop = model.PriceInShop;
            boardgame.MinimumPlayersAllowedToPlay = model.MinimumPlayersAllowedToPlay;
            boardgame.MaximumPlayersAllowedToPlay = model.MaximumPlayersAllowedToPlay;

            context.BoardgamesGenres.RemoveRange(boardgame.BoardgamesGenres);

            if(boardgame.BoardgamesGenres.Count == 0)
            {
                boardgame.BoardgamesGenres.AddRange(new BoardgameGenre[]
                {
                    new BoardgameGenre()
                    {
                        GenreId = model.GenreId_1,
                        BoardgameId = boardgame.Id
                    },
                    new BoardgameGenre()
                    {
                        GenreId = model.GenreId_2,
                        BoardgameId = boardgame.Id
                    }
                });

                if(model.GenreId_3 != null)
                {
                    boardgame.BoardgamesGenres.Add(new BoardgameGenre()
                    {
                        GenreId = (int)model.GenreId_3,
                        BoardgameId = boardgame.Id
                    });
                }
            }

            await context.SaveChangesAsync();
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
