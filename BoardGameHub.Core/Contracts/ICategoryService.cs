using BoardGameHub.Core.Models.CategoryModel;

namespace BoardGameHub.Core.Contracts
{
    public interface ICategoryService
	{
		Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> AllCategoriesBoardgamesAsync();
		Task<IEnumerable<CategoryBoardgameViewModel>> SortByCategoryAsync(int id);
	}
}
