using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.GameReviewViewModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Core.Services
{
	public class GameReviewService : IGameReviewService
	{
		private readonly BoardGameHubDbContext context;
		private readonly IBoardgameService boardgameservice;

		public GameReviewService(BoardGameHubDbContext _context
			, IBoardgameService _boardgameservice)
		{
			context = _context;
			boardgameservice = _boardgameservice;
		}

		public async Task<GameReviewCreateFormModel> GetCreateFormAsync(int boardgameId)
		{
			GameReviewCreateFormModel form = new GameReviewCreateFormModel()
			{
				BoardgameId = boardgameId
			};

			return form;
		}

		public async Task CreateAsync(GameReviewCreateFormModel form, string userId)
		{
			GameReview gameReview = new GameReview()
			{
				Id = await GetLastGameReviewId(form.BoardgameId) + 1,
				ReviewText = form.ReviewText,
				Date = DateTime.Now.ToString(ReservationDateTimeFormat),
				BoardGameId = form.BoardgameId,
				ReviewOwnerId = userId
			};

			Boardgame boardgame = await boardgameservice.ExistsAsync(form.BoardgameId);

			if (boardgame != null)
			{
				boardgame.GameReviews.Add(gameReview);
				await context.SaveChangesAsync();
			}
		}

		public async Task<int> GetLastGameReviewId(int boardgameId)
		{
			Boardgame boardgame = await boardgameservice.ExistsAsync(boardgameId);

			if (!boardgame.GameReviews.Any())
			{
				return 0;
			}

			var lastGameReviewById = boardgame.GameReviews.OrderBy(gr => gr.Id).Last();

			return lastGameReviewById.Id;
		}
	}
}
