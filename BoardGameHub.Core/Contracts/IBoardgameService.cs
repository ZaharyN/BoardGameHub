using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Core.Contracts
{
    public interface IBoardgameService
    {
        Task<IEnumerable<BoardgameActiveViewModel>> ActiveAsync();
        Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync();
        Task PromoteToActiveAsync(int id);
        Task<int> CreateAsync(BoardgameCreateFormModel model);
        Task<BoardgameCreateFormModel> GetCreateFormAsync();
        Task<BoardgameEditFormModel> GetEditFormAsync(Boardgame boardgame);
        Task EditAsync(BoardgameEditFormModel model, Boardgame boardgame);
        Task<BoardgameDeleteFormModel> GetDeleteFormAsync(Boardgame boardgame);
        Task DeleteConfirmed(Boardgame boardgame);
        Task<BoardgameDetailsViewModel> DetailsAsync(int id);
        Task<IEnumerable<BoardgameGenreViewModel>> AllGenresAsync();
        Task<Boardgame> ExistsAsync(int id);
    }
}
