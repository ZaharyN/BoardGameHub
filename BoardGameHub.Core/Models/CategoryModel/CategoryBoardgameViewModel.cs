using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.CategoryModel
{
	public class CategoryBoardgameViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<CategoryViewModel> BoardgameCategories { get; set; } = null!;
		public double? Rating { get; set; }
        public decimal PriceInShop { get; set; }
        public int AppropriateAge { get; set; }
		public double Difficulty { get; set; }
		public string CardImageUrl { get; set; } = string.Empty;
		public int MinimumPlayersAllowedToPlay { get; set; }
		public int MaximumPlayersAllowedToPlay { get; set; }
	}
}
