using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.GameReviewViewModel;

namespace BoardGameHub.Core.Contracts
{
	public interface IGameReviewService
	{
		Task<GameReviewCreateFormModel> GetCreateFormAsync(int boardgameId);
		Task CreateAsync(GameReviewCreateFormModel form, int boardgameId, string userId);
		Task<bool> UserHasComment(string userId, int boardgameId);
    }
}
