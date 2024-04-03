using BoardGameHub.Data.Data.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;
using static BoardGameHub.Core.Constants.MessageConstants;

namespace BoardGameHub.Core.Models.BoardgameViewModels
{
    public class BoardgameCreateFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BoardgameNameMaxLength,
            MinimumLength = BoardgameNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Main genre")]
        public int GenreId_1 { get; set; }

        [Display(Name= "Subgenre 1")]
        public int? GenreId_2 { get; set; }

        [Display(Name = "Subgenre 2")]
        public int? GenreId_3 { get; set; }

        public IEnumerable<BoardgameGenreViewModel> Genres { get; set; } =
            new List<BoardgameGenreViewModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Range(BoardgameRatingMinValue, 
            BoardgameRatingMaxValue, 
            ErrorMessage = ValueMessage)]
        public double? Rating { get; set; }

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

        [Required]
        [Display(Name= "Is upcoming")]
        public bool IsUpcoming { get; set; }
    }
}
