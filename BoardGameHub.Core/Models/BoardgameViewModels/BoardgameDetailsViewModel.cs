using BoardGameHub.Core.Models.CategoryModel;
using BoardGameHub.Data.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.BoardgameViewModels
{
    public class BoardgameDetailsViewModel
    {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<CategoryViewModel> BoardgameCategories { get; set; } = null!;
		public int Rating { get; set; }
		public int AppropriateAge { get; set; }
		public int AveragePlayingTime { get; set; }
		public string Description { get; set; } = string.Empty;
		public double Difficulty { get; set; }
		public string? CardImageUrl { get; set; }
		public string? DetailsImageUrl { get; set; }
		public int YearPublished { get; set; }
		public decimal PriceInShop { get; set; }
		public int MinimumPlayersAllowedToPlay { get; set; }
		public int MaximumPlayersAllowedToPlay { get; set; }
		public List<GameReview> GameReviews { get; set; } = new List<GameReview>();
	}
}
