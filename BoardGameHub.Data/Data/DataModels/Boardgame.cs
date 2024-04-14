using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Data.Data.DataModels
{
    public class Boardgame
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(BoardgameNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public List<BoardgameCategory> BoardgamesCategories{ get; set; } = null!;

        public int Rating { get; set; }

        [Required]
        public int AppropriateAge { get; set; }

        [Required]
        [Display(Name = "Average playing time")]
        public int AveragePlayingTime { get; set; }

        [Required]
        [MaxLength(BoardGameDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(BoardgameDifficultyMinValue, BoardgameDifficultyMaxValue)]
        public double Difficulty { get; set; }

        [Required]
        public string CardImageUrl { get; set; } = string.Empty;

        [Required]
        public string DetailsImageUrl { get; set; } = string.Empty;

        [Required]
        [Range(BoardGameYearMinValue,BoardGameYearMaxValue)]
        public int YearPublished { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(typeof(decimal),
            BoardGamePriceInShopMinValue, 
            BoardGamePriceInShopMaxValue)]
        public decimal PriceInShop { get; set; }

        [Display(Name = "Minimum players")]
        [Required]
        [Range(BoardGameMinimumPlayersMinValue, BoardGameMinimumPlayersMaxValue)]
        public int MinimumPlayersAllowedToPlay { get; set; }

        [Display(Name = "Maximum players")]
        [Required]
        [Range(BoardGameMaximumPlayersMinValue, BoardGameMaximumPlayersMaxValue)]
        public int MaximumPlayersAllowedToPlay { get; set; }

        public List<GameReview>? GameReviews { get; set; } = new List<GameReview>();

        [Required]
        public bool IsReserved { get; set; }

        public Reservation? Reservation { get; set; }

        [ForeignKey(nameof(Reservation))]
        public int? ReservationId { get; set; }
        public bool IsUpcoming { get; set; }
    }
}
