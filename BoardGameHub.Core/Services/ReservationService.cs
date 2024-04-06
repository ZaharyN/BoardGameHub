using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Core.Services
{
	public class ReservationService : IReservationService
	{
		private readonly BoardGameHubDbContext context;

        public ReservationService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

		public Task<ReservationCreateFormModel> GetCreateReservationFormAsync()
		{
			throw new NotImplementedException();
		}

		public Task<int> CreateReservationAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ReservationViewModel>> MyReservationsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ReservationDetailsViewModel> ReservationDetailsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Reservation> GetDeleteFormAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ReservationDeleteFormModel> DeleteConfirmedAsync()
		{
			throw new NotImplementedException();
		}
	}
}
