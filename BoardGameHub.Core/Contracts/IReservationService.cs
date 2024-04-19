using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Core.Contracts
{
	public interface IReservationService
	{
		Task<ReservationCreateFormModel> GetCreateReservationFormAsync();
		Task CreateReservationAsync(ReservationCreateFormModel form, string userId, DateTime date);
		Task<IEnumerable<ReservationViewModel>> MineAsync(string id);
		Task<ReservationDetailsViewModel> ReservationDetailsAsync(Reservation reservation, string userId);
		Task<ReservationDeleteFormModel> GetDeleteFormAsync(Reservation reservation);
		Task DeleteConfirmedAsync(ReservationDeleteFormModel form);
		Task<ApplicationUser> GetUser(string userId);
		Task<List<ReservationBoardgameViewModel>> GetAllFreeBoardgamesAsync();
		Task<List<ReservationPlaceViewModel>> GetAllFreeReservationPlacesAsync();
		Task<Reservation> GetReservationAsync(int reservationId);
		Task<bool> UserHasReservation(string userId, DateTime date);
		Task<int> GetLastReservationId();
	}
}
