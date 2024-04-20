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

        [RegularExpression(ApplicationUserPhoneNumber)]
        public string? PhoneNumber {  get; set; }

        [Required]
        public ReservationPlace ReservationPlace { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ReservationPlace))]
        public int ReservationPlaceId { get; set; }

        [ForeignKey(nameof(BoardgameReserved))]
		public int? BoardgameReservedId { get; set; }
        public Boardgame? BoardgameReserved { get; set; }
        public bool IsExpired { get; set; }
    }
}
