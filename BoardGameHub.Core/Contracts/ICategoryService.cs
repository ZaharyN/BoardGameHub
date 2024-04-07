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

		Task<IEnumerable<BoardgameGenreViewModel>> ViewAllGenresAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> ViewAllGenresBoardgamesAsync();
		Task<IEnumerable<BoardgameActiveViewModel>> SortByGenreAsync(int id);
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
