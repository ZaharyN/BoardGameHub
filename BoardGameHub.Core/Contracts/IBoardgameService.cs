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
        Task<BoardgameCreateFormModel> CreateAsync();
        Task<BoardgameEditViewModel> EditAsync(int id);
        Task EditAsync(BoardgameEditViewModel model);
        Task Delete(int id);
        Task<BoardgameDetailsViewModel> DetailsAsync(int id);
        Task<IEnumerable<BoardgameGenreViewModel>> AllGenresAsync();
        Task<Boardgame> ExistsAsync(int id);
    }
}
