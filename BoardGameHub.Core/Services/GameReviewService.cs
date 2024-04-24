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
			Boardgame boardgame = await boardgameservice.ExistsAsync(boardgameId);

			GameReviewCreateFormModel form = new GameReviewCreateFormModel()
			{
				BoardgameId = boardgameId,
				BoardgameName = boardgame.Name
			};

			return form;
		}

		public async Task CreateAsync(GameReviewCreateFormModel form,int boardgameId, string userId)
		{
			GameReview gameReview = new GameReview()
			{
				ReviewText = form.ReviewText,
				Date = DateTime.Now.ToString(ReservationDateTimeFormat),
				BoardGameId = boardgameId,
				ReviewOwnerId = userId
			};

			if(gameReview != null)
			{
				context.GameReviews.Add(gameReview);
			}

            await context.SaveChangesAsync();
        }

        public async Task<bool> UserHasComment(string userId, int boardgameId)
        {
            return context.GameReviews
                .Any(gr => gr.BoardGameId == boardgameId
                && gr.ReviewOwnerId == userId);
        }
    }
}
