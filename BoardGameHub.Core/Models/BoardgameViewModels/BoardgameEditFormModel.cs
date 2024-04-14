using System.ComponentModel.DataAnnotations;
using BoardGameHub.Core.Models.CategoryModel;
using static BoardGameHub.Core.Constants.MessageConstants;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Core.Models.BoardgameViewModels
{
    public class BoardgameEditFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BoardgameNameMaxLength,
            MinimumLength = BoardgameNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Main category")]
        public int CategoryId_1 { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Subcategory 1")]
        public int CategoryId_2 { get; set; }

        [Display(Name = "Subcategory 2")]
        public int? CategoryId_3 { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; } =
            new List<CategoryViewModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Range(BoardgameRatingMinValue,
            BoardgameRatingMaxValue,
            ErrorMessage = ValueMessage)]
        public int Rating { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(BoardgameAppropriateAgeMinValue,
            BoardgameAppropriateAgeMaxValue,
            ErrorMessage = ValueMessage)]
        public int AppropriateAge { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Average playing time")]
        public int AveragePlayingTime { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BoardGameDescriptionMaxLength,
            MinimumLength = BoardGameDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(BoardgameDifficultyMinValue,
            BoardgameDifficultyMaxValue,
            ErrorMessage = ValueMessage)]
        public double Difficulty { get; set; }

        public string? CardImageUrl { get; set; } = string.Empty;

        public string? DetailsImageUrl { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Year published")]
        [Range(BoardGameYearMinValue,
            BoardGameYearMaxValue,
            ErrorMessage = ValueMessage)]
        public int YearPublished { get; set; }

        [Required]
        [Range(typeof(decimal),
            BoardGamePriceInShopMinValue,
            BoardGamePriceInShopMaxValue,
            ErrorMessage = ValueMessage)]
        public decimal PriceInShop { get; set; }

        [Display(Name = "Minimum players")]
        [Required]
        [Range(BoardGameMinimumPlayersMinValue,
            BoardGameMinimumPlayersMaxValue,
            ErrorMessage = ValueMessage)]
        public int MinimumPlayersAllowedToPlay { get; set; }

        [Display(Name = "Maximum players")]
        [Required]
        [Range(BoardGameMaximumPlayersMinValue,
            BoardGameMaximumPlayersMaxValue,
            ErrorMessage = ValueMessage)]
        public int MaximumPlayersAllowedToPlay { get; set; }
    }
}
