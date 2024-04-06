using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Models.CategoryViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Contracts
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByGenreAsync(int id);
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
