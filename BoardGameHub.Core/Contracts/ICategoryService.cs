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
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByGenreAsync(int id);
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestRatingAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestRatingAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestDifficultyAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestDifficultyAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByLowestPriceAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByHighestPriceAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByMinPlayersAsync();
		public Task<IEnumerable<CategoryBoardgameViewModel>> SortByMaxPlayersAsync();
	}
}
