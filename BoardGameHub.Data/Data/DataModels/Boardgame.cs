using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; } = null!;

        [Range(0, 5)]
        public int? Rating { get; set; }

        [Required]
        [Display(Name = "Average playing time")]
        public int AveragePlayingTime { get; set; }

        [Required]
        [MaxLength(BoardGameDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.00, 5.00)]
        public double Difficulty { get; set; }

        [Required]
        public DateTime YearPublished { get; set; }

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

        public List<GameReview>? Reviews { get; set; } = new List<GameReview>();

        [Required]
        public bool IsReserved { get; set; }

        public Reservation? Reservation { get; set; }

        [ForeignKey(nameof(Reservation))]
        public int ReservationId { get; set; }
        public bool IsUpcoming { get; set; }
    }
}
