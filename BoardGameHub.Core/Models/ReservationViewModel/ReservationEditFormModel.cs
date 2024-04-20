using System.ComponentModel.DataAnnotations;
using static BoardGameHub.Data.Constants.DataConstants;
using static BoardGameHub.Core.Constants.MessageConstants;

namespace BoardGameHub.Core.Models.ReservationViewModel
{
    public class ReservationEditFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserFirstNameMaxLength,
           MinimumLength = UserFirstNameMinLength,
           ErrorMessage = LengthMessage)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserLastNameMaxLength,
            MinimumLength = UserLastNameMinLength,
            ErrorMessage = LengthMessage)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegularExpression(ApplicationUserPhoneNumber)]
        public string? PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string DateTime { get; set; } = string.Empty;

        [StringLength(ReservationAdditionalCommentMaxValue)]
        public string? AdditionalComment { get; set; }
        public int? BoardgameReservedId { get; set; }
        public string? BoardgameReservedName { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public int PlaceReservedId { get; set; }
        public string PlaceReservedName { get; set; } = string.Empty;

        public List<ReservationBoardgameViewModel> FreeBoardgames { get; set; } =
            new List<ReservationBoardgameViewModel>();

        public List<ReservationPlaceViewModel> FreePlaces { get; set; } = new List<ReservationPlaceViewModel>();
    }
}
