using BoardGameHub.Data.Data.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Core.Models.GameReviewViewModel
{
	public class GameReviewCreateFormModel
	{
		public string BoardgameName { get; set; } = string.Empty;

        [Required]
		[StringLength(GameReviewMaxLength)]
		public string ReviewText { get; set; } = string.Empty;

        public int BoardgameId { get; set; }
    }
}
