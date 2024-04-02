using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Core.Contracts
{
    public interface IBoardgameService
    {
        Task<IEnumerable<BoardgameActiveViewModel>> ActiveAsync();
        Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync();
        Task PromoteToActiveAsync(int id);
        Task CreateAsync(BoardgameCreateViewModel model, string userId);
        Task<BoardgameCreateViewModel> CreateAsync();
        Task<BoardgameEditViewModel> EditAsync(int id);
        Task EditAsync(BoardgameEditViewModel model, string userId);
        Task Delete(int id);
        Task<BoardgameDetailsViewModel> Details(int id);
        Task<IEnumerable<BoardgameGenreViewModel>> AllGenresAsync(); 
    }
}
