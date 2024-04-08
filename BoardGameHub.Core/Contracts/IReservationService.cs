using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Contracts
{
	public interface IReservationService
	{
		Task<ReservationCreateFormModel> GetCreateReservationFormAsync();
		Task CreateReservationAsync(ReservationCreateFormModel form, string userId);
		Task<IEnumerable<ReservationViewModel>> MyReservationsAsync(string id);
		Task<ReservationDetailsViewModel> ReservationDetailsAsync();
		Task<Reservation> GetDeleteFormAsync();
		Task<ReservationDeleteFormModel> DeleteConfirmedAsync();
		Task<int> LastReservationId();
		Task<ApplicationUser> GetUser(string userId);
	}
}
