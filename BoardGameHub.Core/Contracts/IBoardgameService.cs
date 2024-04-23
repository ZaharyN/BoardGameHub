using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryModel;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Http;

namespace BoardGameHub.Core.Contracts
{
    public interface IBoardgameService
    {
        Task<IEnumerable<BoardgameActiveViewModel>> ActiveAsync();
        Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync();
        Task PromoteToActiveAsync(int id);
        Task<int> CreateAsync(BoardgameCreateFormModel form);
        Task<BoardgameCreateFormModel> GetCreateFormAsync();
        Task<BoardgameEditFormModel> GetEditFormAsync(Boardgame boardgame);
        Task EditAsync(BoardgameEditFormModel model, Boardgame boardgame);
        Task<BoardgameDeleteFormModel> GetDeleteFormAsync(Boardgame boardgame);
        Task DeleteAsync(Boardgame boardgame);
        Task<BoardgameDetailsViewModel> DetailsAsync(int id);
        Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync();
        Task<Boardgame> ExistsAsync(int id);
        Task<BoardgameActiveViewModel[]> GetRandomBoardgames();
        Task<string> UploadImage(IFormFile image);
    }
}
