using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Data.Data.DataModels
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser ReservationOwner { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ReservationOwner))]
        public string ReservationOwnerId { get; set; }

        [Display(Name = "Date and time")]
        [Required]
        public DateTime DateTime { get; set; }

        [MaxLength(ReservationAdditionalCommentMaxValue)]
        public string? AdditionalComment { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(typeof(decimal),
            ReservationTotalPriceMinValue,
            ReservationTotalPriceMaxValue)]
        public decimal TotalPrice { get; set; }

        [Required]
        public List<ReservationPlace> ReservationPlaces { get; set; } = new List<ReservationPlace>();

        public List<Boardgame>? BoardgamesReserved { get; set; } = new List<Boardgame>();
    }
}
