using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryModel;
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
			IEnumerable<CategoryViewModel> Categorys = await context.Categories
				.Select(g => new CategoryViewModel()
				{
					Id = g.Id,
					Name = g.Name
				})
				.ToListAsync();

			return Categorys;
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

			boardgame.BoardgamesCategories.Add(new BoardgameCategory()
			{
				BoardgameId = boardgame.Id,
				CategoryId = model.CategoryId_1
			});

			if (model.CategoryId_2 != null)
			{
				boardgame.BoardgamesCategories.Add(new BoardgameCategory()
				{
					BoardgameId = boardgame.Id,
					CategoryId = (int)model.CategoryId_2
				});
			}

			if (model.CategoryId_3 != null)
			{
				boardgame.BoardgamesCategories.Add(new BoardgameCategory()
				{
					BoardgameId = boardgame.Id,
					CategoryId = (int)model.CategoryId_3
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
			Boardgame boardgame = await ExistsAsync(id);

			boardgame.BoardgamesCategories = await context.BoardgamesCategories
												.Include(bg => bg.Category)
												.Where(bg => bg.BoardgameId == id)
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
				Categories = await AllCategoriesAsync(),
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

			var boardgameCategorys = boardgame.BoardgamesCategories.ToList();

			model.CategoryId_1 = boardgameCategorys[0].CategoryId;
			model.CategoryId_2 = boardgameCategorys[1].CategoryId;

			if (boardgameCategorys.Count > 2)
			{
				model.CategoryId_3 = boardgameCategorys[2].CategoryId;
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

			context.BoardgamesCategories.RemoveRange(boardgame.BoardgamesCategories);

			if (boardgame.BoardgamesCategories.Count == 0)
			{
				boardgame.BoardgamesCategories.AddRange(new BoardgameCategory[]
				{
					new BoardgameCategory()
					{
						CategoryId = model.CategoryId_1,
						BoardgameId = boardgame.Id
					},
					new BoardgameCategory()
					{
						CategoryId = model.CategoryId_2,
						BoardgameId = boardgame.Id
					}
				});

				if (model.CategoryId_3 != null)
				{
					boardgame.BoardgamesCategories.Add(new BoardgameCategory()
					{
						CategoryId = (int)model.CategoryId_3,
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

		public async Task DeleteConfirmed(Boardgame boardgame)
		{
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
	}
}
