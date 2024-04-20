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
		Task<ReservationEditFormModel> GetEditFormAsync(int reservationId);
		Task EditAsync(ReservationEditFormModel form, DateTime dateTime);
		Task<ReservationDeleteFormModel> GetDeleteFormAsync(Reservation reservation);
		Task DeleteConfirmedAsync(ReservationDeleteFormModel form);
        Task<IEnumerable<ReservationViewModel>> GetAllExpiredAsync();
		Task FreeTablesAsync(int id);
        Task<ApplicationUser> GetUser(string userId);
		Task<List<ReservationBoardgameViewModel>> GetAllFreeBoardgamesAsync();
		Task<List<ReservationPlaceViewModel>> GetAllFreeReservationPlacesAsync();
		Task<Reservation> GetReservationAsync(int reservationId);
		Task<bool> UserHasReservation(string userId, DateTime date);
		Task<IEnumerable<ReservationViewModel>> GetAllActiveAsync();
	}
}
