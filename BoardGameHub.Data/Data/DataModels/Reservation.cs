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
        public string ReservationOwnerId { get; set; } = string.Empty;

        [Display(Name = "Date and time")]
        [Required]
        public DateTime DateTime { get; set; }

        [MaxLength(ReservationAdditionalCommentMaxValue)]
        public string? AdditionalComment { get; set; }

		[Required]
        public List<ReservationPlace> ReservationPlaces { get; set; } = new List<ReservationPlace>();

		[ForeignKey(nameof(BoardgameReserved))]
		public int? BoardgameReservedId { get; set; }
        public Boardgame? BoardgameReserved { get; set; }
    }
}
