using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
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

        public async Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync()
        {
            IEnumerable<CategoryViewModel> categories = await context.Categories
                .Select(g => new CategoryViewModel()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToListAsync();

            return categories;
        }

        public async Task<int> CreateAsync(BoardgameCreateFormModel form)
        {
            string cardImageDirectory = await UploadImage(form.CardImage);
            string detailsImageDirectory = await UploadImage(form.DetailsImage);

            List<BoardgameCategory> boardgameCategories = new List<BoardgameCategory>();

            var boardgame = new Boardgame()
            {
                Name = form.Name,
                Rating = form.Rating,
                AppropriateAge = form.AppropriateAge,
                AveragePlayingTime = form.AveragePlayingTime,
                Description = form.Description,
                Difficulty = form.Difficulty,
                YearPublished = form.YearPublished,
                PriceInShop = form.PriceInShop,
                MinimumPlayersAllowedToPlay = form.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = form.MaximumPlayersAllowedToPlay,
                IsUpcoming = form.IsUpcoming,
                BoardgamesCategories = boardgameCategories,
                CardImageUrl = $"/assets/games/{cardImageDirectory}",
                DetailsImageUrl = $"/assets/games/{detailsImageDirectory}",
                IsReserved = false
            };

            foreach (int selectedCategoryId in form.SelectedCategoriesId)
            {
                Category category = await context.Categories.FindAsync(selectedCategoryId);

                if (category != null)
                {
                    boardgame.BoardgamesCategories.Add(new BoardgameCategory
                    {
                        CategoryId = category.Id,
                        BoardgameId = boardgame.Id
                    });
                }
            }

            await context.Boardgames.AddAsync(boardgame);
            await context.SaveChangesAsync();

            return boardgame.Id;
        }

        public async Task<BoardgameCreateFormModel> GetCreateFormAsync()
        {
            BoardgameCreateFormModel model = new BoardgameCreateFormModel()
            {
                Categories =
                    await context.Categories.
                    Select(g => new CategoryViewModel()
                    {
                        Id = g.Id,
                        Name = g.Name
                    })
                    .ToListAsync()
            };

            return model;
        }

        public async Task<BoardgameDetailsViewModel> DetailsAsync(int id)
        {
            Boardgame boardgame = await ExistsAsync(id) ?? throw new ArgumentNullException();

            boardgame.BoardgamesCategories = await context.BoardgamesCategories
                .Include(bg => bg.Category)
                .Where(bg => bg.BoardgameId == id)
                .ToListAsync();

            boardgame.GameReviews = await context.GameReviews
                .Include(gr => gr.ReviewOwner)
                .Where(gr => gr.BoardGameId == id)
                .ToListAsync();

            BoardgameDetailsViewModel model = new BoardgameDetailsViewModel()
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
                BoardgameCategories = boardgame.BoardgamesCategories
                    .Select(bg => new CategoryViewModel()
                    {
                        Id = bg.CategoryId,
                        Name = bg.Category.Name
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
                MaximumPlayersAllowedToPlay = boardgame.MaximumPlayersAllowedToPlay,
                GameReviews = boardgame.GameReviews
            };

            return model;
        }

        public async Task<BoardgameEditFormModel> GetEditFormAsync(Boardgame boardgame)
        {
            BoardgameEditFormModel model = new BoardgameEditFormModel()
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
                Categories = await AllCategoriesAsync(),
                Rating = boardgame.Rating,
                AppropriateAge = boardgame.AppropriateAge,
                AveragePlayingTime = boardgame.AveragePlayingTime,
                Description = boardgame.Description,
                Difficulty = boardgame.Difficulty,
                YearPublished = boardgame.YearPublished,
                PriceInShop = boardgame.PriceInShop,
                MinimumPlayersAllowedToPlay = boardgame.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = boardgame.MaximumPlayersAllowedToPlay,
                IsUpcoming = boardgame.IsUpcoming
            };

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
            boardgame.YearPublished = model.YearPublished;
            boardgame.PriceInShop = model.PriceInShop;
            boardgame.MinimumPlayersAllowedToPlay = model.MinimumPlayersAllowedToPlay;
            boardgame.MaximumPlayersAllowedToPlay = model.MaximumPlayersAllowedToPlay;
            boardgame.IsUpcoming = model.IsUpcoming;

            List<BoardgameCategory> bgCategories = await context.BoardgamesCategories
                    .Where(bg => bg.BoardgameId == boardgame.Id)
                    .ToListAsync();
            context.BoardgamesCategories.RemoveRange(bgCategories);

            foreach (var categoryId in model.NewCategoriesId)
            {
                boardgame.BoardgamesCategories.Add(new BoardgameCategory
                {
                    BoardgameId = boardgame.Id,
                    CategoryId = categoryId
                });
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

        public async Task<BoardgameDeleteFormModel> GetDeleteFormAsync(Boardgame boardgame)
        {
            BoardgameDeleteFormModel model = new BoardgameDeleteFormModel()
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
            };

            return model;
        }

        public async Task DeleteAsync(Boardgame boardgame)
        {
            var boardgameGameReviews = boardgame.GameReviews.ToList();

            if (boardgameGameReviews.Any())
            {
                context.GameReviews.RemoveRange(boardgameGameReviews);
            }

            var boardgameCategories = boardgame.BoardgamesCategories.ToList();
            context.RemoveRange(boardgameCategories);
            context.Boardgames.Remove(boardgame);

            await context.SaveChangesAsync();
        }

        public async Task<BoardgameActiveViewModel[]> GetRandomBoardgames()
        {
            Random random = new Random();

            int skipper = random.Next(0, await context.Boardgames.CountAsync() - 3);

            return await context.Boardgames
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
                .OrderBy(b => Guid.NewGuid())
                .Skip(skipper)
                .Take(3)
                .ToArrayAsync();
        }

        public async Task<string> UploadImage(IFormFile image)
        {
            string uploadsFolder = Path.Combine(new string[] { "wwwroot", "assets", "games" });

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string imageName = Path.GetFileName(image.FileName);
            string cardSavePath = Path.Combine(uploadsFolder, imageName);

            using (FileStream stream = new FileStream(cardSavePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return imageName;
        }
    }
}
