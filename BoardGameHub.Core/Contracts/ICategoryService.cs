using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Contracts
{
    public interface ICategoryService
	{
		Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> AllCategoriesBoardgamesAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByCategoryAsync(int id);
		Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestRatingAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestRatingAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestDifficultyAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestDifficultyAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByLowestPriceAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByHighestPriceAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByMinPlayersAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByMaxPlayersAsync();
	}
}
