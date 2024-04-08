using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Core.Services
{
	public class ReservationService : IReservationService
	{
		private readonly BoardGameHubDbContext context;

		public ReservationService(BoardGameHubDbContext _context)
		{
			context = _context;
		}

		public async Task<ReservationCreateFormModel> GetCreateReservationFormAsync()
		{
			var form = new ReservationCreateFormModel()
			{
				FreeBoardgames = await context.Boardgames
				.Where(b => b.IsReserved == false
				&& b.IsUpcoming == false)
				.Select(b => new ReservationBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name
				})
				.ToListAsync(),

				FreePlaces = await context.ReservationPlaces
					.Where(rp => rp.IsReserved == false)
					.Select(rp => new ReservationPlaceViewModel()
					{
						Id = rp.Id,
						Name = rp.Name
					}).ToListAsync()
			};

			return form;
		}

		public async Task CreateReservationAsync(ReservationCreateFormModel form, string userId)
		{
			if (!DateTime.TryParseExact(form.DateTime,
				ReservationDateTimeFormat,
				CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out DateTime dateTime))
			{
				throw new InvalidOperationException("Invalid date or time format");
			}

			Reservation reservation = new Reservation()
			{
				//Id = await LastReservationId() + 1,
				//ReservationOwner = await GetUser(userId),
				//ReservationOwnerId = userId,
				//DateTime = dateTime,
				//AdditionalComment = form.AdditionalComment != null ? 
				//	form.AdditionalComment : null,
				//ReservationPlaces = form.PlacesReserved
				//	.Select(pr => new ReservationPlace()
				//	{
				//		Id = pr.Id,
				//		Name=pr.Name,
				//	})
				
			};

		}

		public Task<IEnumerable<ReservationViewModel>> MyReservationsAsync(string id)
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

		public async Task<int> LastReservationId()
		{
			Reservation? lastReservation = await context.Reservations
				.OrderBy(r => r.Id)
				.LastOrDefaultAsync();

			return lastReservation == null ? 0 : lastReservation.Id;
		}

		public async Task<ApplicationUser> GetUser(string id)
		{
			var user = await context.ApplicationUsers.FirstOrDefaultAsync(u => u.Id == id);

			return user;
		}
	}
}
