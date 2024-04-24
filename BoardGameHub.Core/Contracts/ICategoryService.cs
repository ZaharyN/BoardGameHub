using BoardGameHub.Core.Models.CategoryModel;

namespace BoardGameHub.Core.Contracts
{
    public interface ICategoryService
	{
		Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> AllCategoriesBoardgamesAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByCategoryAsync(int id);
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestRatingAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestRatingAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestDifficultyAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestDifficultyAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestPriceAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestPriceAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByMinPlayersAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByMaxPlayersAsync();
	}
}
