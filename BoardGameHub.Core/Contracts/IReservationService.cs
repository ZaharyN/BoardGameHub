using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Core.Contracts
{
	public interface IReservationService
	{
		Task<ReservationCreateFormModel> GetCreateReservationFormAsync();
		Task CreateReservationAsync(ReservationCreateFormModel form, string userId);
		Task<IEnumerable<ReservationViewModel>> MyReservationsAsync(string id);
		Task<ReservationDetailsViewModel> ReservationDetailsAsync(Reservation reservation);
		Task<ReservationDeleteFormModel> GetDeleteFormAsync(Reservation reservation);
		Task DeleteConfirmedAsync(ReservationDeleteFormModel form);
		Task<int> LastReservationId();
		Task<ApplicationUser> GetUser(string userId);
		Task<List<ReservationBoardgameViewModel>> GetAllFreeBoardgamesAsync();
		Task<List<ReservationPlaceViewModel>> GetAllFreeReservationPlacesAsync();
		Task<Reservation> GetReservationAsync(int reservationId);
	}
}
