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
		Task<int> CreateReservationAsync();
		Task<IEnumerable<ReservationViewModel>> MyReservationsAsync();
		Task<ReservationDetailsViewModel> ReservationDetailsAsync();
		Task<Reservation> GetDeleteFormAsync();
		Task<ReservationDeleteFormModel> DeleteConfirmedAsync();

	}
}
