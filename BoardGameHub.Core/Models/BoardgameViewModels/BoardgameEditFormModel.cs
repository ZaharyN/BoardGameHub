﻿using System.ComponentModel.DataAnnotations;
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

        public List<int> NewCategoriesId { get; set; } = new List<int>();

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
        [Range(BoardgameAveragePlayingTimeMinValue,
            BoardgameAveragePlayingTimeMaxValue,
            ErrorMessage = ValueMessage)]
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
        public bool IsUpcoming { get; set; }
    }
}
