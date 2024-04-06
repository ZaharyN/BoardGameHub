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
		public Task<ReservationCreateFormModel> GetCreateReservationFormAsync();
		public Task<int> CreateReservationAsync();
		public Task<IEnumerable<ReservationViewModel>> MyReservationsAsync();
		public Task<ReservationDetailsViewModel> ReservationDetailsAsync();
		public Task<Reservation> GetDeleteFormAsync();
		public Task<ReservationDeleteFormModel> DeleteConfirmedAsync();

	}
}
