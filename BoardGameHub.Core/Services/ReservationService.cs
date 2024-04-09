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
					Name = b.Name,
				})
				.ToListAsync(),

				FreePlaces = await context.ReservationPlaces
					.Where(rp => rp.IsReserved == false)
					.Select(rp => new ReservationPlaceViewModel()
					{
						Id = rp.Id,
						Name = rp.Name,
						PlaceTypeId = rp.PlaceTypeId,
					})
					.ToListAsync()
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

			List<ReservationPlace> places = new List<ReservationPlace>();
			List<Boardgame> games = new List<Boardgame>();

			foreach (var resPlace in form.PlacesReserved)
			{
				ReservationPlace currentPlace = await context.ReservationPlaces.FindAsync(resPlace.Id);

				if(resPlace != null)
				{
					places.Add(currentPlace);
				}
			}

			foreach (var gameReserved in form.BoardgamesReserved)
			{
				Boardgame currentBg = await context.Boardgames.FindAsync(gameReserved.Id);

				if(currentBg != null)
				{
					games.Add(currentBg);
				}
			}

			Reservation reservation = new Reservation()
			{
				Id = await LastReservationId() + 1,
				ReservationOwnerId = userId,
				DateTime = dateTime,
				AdditionalComment = form.AdditionalComment ?? null,
				ReservationPlaces = places,
				BoardgamesReserved = games
			};

			context.Reservations.Add(reservation);
			await context.SaveChangesAsync();
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
