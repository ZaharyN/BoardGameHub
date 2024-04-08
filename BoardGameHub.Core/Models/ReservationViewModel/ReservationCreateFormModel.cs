using BoardGameHub.Data.Data.DataModels;
using System.ComponentModel.DataAnnotations;
using static BoardGameHub.Core.Constants.MessageConstants;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationCreateFormModel
	{
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserFirstNameMaxLength,
            MinimumLength = UserFirstNameMinLength,
            ErrorMessage = LengthMessage)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
		[StringLength(UserLastNameMaxLength,
			MinimumLength = UserLastNameMinLength,
			ErrorMessage = LengthMessage)]
		public string LastName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(ApplicationUserPhoneNumber)]
        public string? PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string DateTime { get; set; } = string.Empty;

        [StringLength(ReservationAdditionalCommentMaxValue)]
        public string? AdditionalComment { get; set; }

        public List<ReservationBoardgameViewModel> BoardgamesReserved { get; set; } = 
            new List<ReservationBoardgameViewModel>();

        [Required]
        public List<ReservationPlaceViewModel> PlacesReserved { get; set; } = new List<ReservationPlaceViewModel>();

        public List<ReservationBoardgameViewModel> FreeBoardgames { get; set; } = 
            new List<ReservationBoardgameViewModel>();

        public List<ReservationPlaceViewModel> FreePlaces { get; set; } = new List<ReservationPlaceViewModel>();
    }
}
