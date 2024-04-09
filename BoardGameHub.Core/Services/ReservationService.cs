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
				FreeBoardgames = await GetAllFreeBoardgamesAsync(),

				FreePlaces = await GetAllFreeReservationPlacesAsync()
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

				if (resPlace != null)
				{
					places.Add(currentPlace);
				}
			}

			foreach (var gameReserved in form.BoardgamesReserved)
			{
				Boardgame currentBg = await context.Boardgames.FindAsync(gameReserved.Id);

				if (currentBg != null)
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

		public async Task<IEnumerable<ReservationViewModel>> MyReservationsAsync(string id)
		{
			string userName = GetUser(id).Result.FirstName;

			var reservations = await context.Reservations
				.Where(r => r.ReservationOwnerId == id)
				.Select(r => new ReservationViewModel()
				{
					Id = r.Id,
					ReservationName = $"{userName}'s reservation",
					DateTime = r.DateTime.ToString(ReservationDateTimeFormat)
				})
				.ToListAsync();

			return reservations;
		}

		public async Task<ReservationDetailsViewModel> ReservationDetailsAsync(Reservation reservation)
		{
			var model = new ReservationDetailsViewModel()
			{
				Id = reservation.Id,
				DateTime = reservation.DateTime.ToString(ReservationDateTimeFormat),
				AdditionalComment = reservation.AdditionalComment ?? null,
				PlacesReserved = reservation.ReservationPlaces,
				BoardgamesReserved = reservation.BoardgamesReserved
			};

			return model;
		}

		public async Task<ReservationDeleteFormModel> GetDeleteFormAsync(Reservation reservation)
		{
			var form = new ReservationDeleteFormModel()
			{
				Id= reservation.Id,
				DateTime = reservation.DateTime
			};

			return form;
		}

		public async Task DeleteConfirmedAsync(ReservationDeleteFormModel form)
		{
			Reservation reservation = await context.Reservations.FindAsync(form.Id);

			foreach (var place in reservation.ReservationPlaces)
			{
				place.IsReserved = false;
			}
			foreach (var boardgame in reservation.BoardgamesReserved)
			{
				boardgame.IsReserved = false;
			}

			context.Reservations.Remove(reservation);
			await context.SaveChangesAsync();

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

		public async Task<List<ReservationBoardgameViewModel>> GetAllFreeBoardgamesAsync()
		{
			return await context.Boardgames
				.Where(b => b.IsReserved == false
				&& b.IsUpcoming == false)
				.Select(b => new ReservationBoardgameViewModel()
				{
					Id = b.Id,
					Name = b.Name,
				})
				.ToListAsync();
		}

		public async Task<List<ReservationPlaceViewModel>> GetAllFreeReservationPlacesAsync()
		{
			return await context.ReservationPlaces
					.Where(rp => rp.IsReserved == false)
					.Select(rp => new ReservationPlaceViewModel()
					{
						Id = rp.Id,
						Name = rp.Name,
						PlaceTypeId = rp.PlaceTypeId,
					})
					.ToListAsync();
		}

		public async Task<Reservation> GetReservationAsync(int id)
		{
			return await context.Reservations.FindAsync(id);
		}
	}

}
