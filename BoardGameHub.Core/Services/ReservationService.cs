using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static BoardGameHub.Data.Constants.DataConstants;
using static BoardGameHub.Core.Constants.OtherConstants;

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

		public async Task CreateReservationAsync(ReservationCreateFormModel form, string userId, DateTime dateTime)
		{
			ReservationPlace? placeReserved = await context.ReservationPlaces.FindAsync(form.PlaceReservedId);

			Boardgame? boardgameReserved = await context.Boardgames.FindAsync(form.BoardgameReservedId);

			Reservation reservation = new Reservation()
			{
				ReservationOwnerId = userId,
				DateTime = dateTime,
				AdditionalComment = form.AdditionalComment,
				PhoneNumber = form.PhoneNumber,
				ReservationPlaceId = placeReserved.Id,
				BoardgameReservedId = boardgameReserved?.Id is null ? null : boardgameReserved.Id   
			};

			await context.Reservations.AddAsync(reservation);
			await context.SaveChangesAsync();

			placeReserved.IsReserved = true;
			placeReserved.ReservationId = reservation.Id;

			if (boardgameReserved != null)
			{
				boardgameReserved.IsReserved = true;
				boardgameReserved.ReservationId = reservation.Id;
			}

			await context.SaveChangesAsync();
		}

		public async Task<IEnumerable<ReservationViewModel>> MineAsync(string id)
		{
			string userName = GetUser(id).Result.FirstName;

			var reservations = await context.Reservations
				.Where(r => r.ReservationOwnerId == id
				&& r.DateTime >= DateTime.Now)
				.Select(r => new ReservationViewModel()
				{
					Id = r.Id,
					ReservationImage = ReservationImagePath,
					ReservationName = $"{userName}'s reservation",
					DateTime = r.DateTime.ToString(ReservationDateTimeFormat)
				})
				.ToListAsync();

			return reservations;
		}

		public async Task<ReservationDetailsViewModel> ReservationDetailsAsync(Reservation reservation, string userId)
		{
			string userName = GetUser(userId).Result.FirstName;

			var model = new ReservationDetailsViewModel()
			{
				Id = reservation.Id,
				ReservationName = $"{reservation.ReservationOwner.FirstName}'s reservation",
				ReservationImage = ReservationImagePath,
				DateTime = reservation.DateTime.ToString(ReservationDateTimeFormat),
				AdditionalComment = reservation.AdditionalComment,
				PhoneNumber = reservation.PhoneNumber,
				PlaceReservedName = reservation.ReservationPlace.Name,
				BoardgameReservedName = reservation.BoardgameReserved?.Name is null ? "None" : reservation.BoardgameReserved.Name,
			};

			return model;
		}

		public async Task<ReservationEditFormModel> GetEditFormAsync(int reservationId)
		{
			Reservation reservation = await GetReservationAsync(reservationId);

			var form = new ReservationEditFormModel()
			{
				Id = reservation.Id,
				FirstName = reservation.ReservationOwner.FirstName,
				LastName = reservation.ReservationOwner.LastName,
				PhoneNumber = reservation.PhoneNumber,
				DateTime = reservation.DateTime.ToString(ReservationDateTimeFormat),
				AdditionalComment = reservation.AdditionalComment,
				BoardgameReservedId = reservation.BoardgameReserved?.Id,
				BoardgameReservedName = reservation.BoardgameReserved?.Name,
				PlaceReservedId = reservation.ReservationPlaceId,
				PlaceReservedName = reservation.ReservationPlace.Name,
				FreeBoardgames = await GetAllFreeBoardgamesAsync(),
				FreePlaces = await GetAllFreeReservationPlacesAsync()
			};

			return form;
		}

		public async Task EditAsync(ReservationEditFormModel form, DateTime dateTime)
        {
			var reservation = await GetReservationAsync(form.Id) ?? throw new ArgumentNullException(nameof(form));

			var oldBoardgameId = reservation.BoardgameReservedId;
			int oldPlaceReservedId = reservation.ReservationPlaceId;

			reservation.ReservationOwner.FirstName = form.FirstName;
			reservation.ReservationOwner.LastName = form.LastName;
			reservation.PhoneNumber = form.PhoneNumber;
			reservation.DateTime = dateTime;
			reservation.AdditionalComment = form.AdditionalComment;
			reservation.BoardgameReservedId = form.BoardgameReservedId;
			reservation.ReservationPlaceId = form.PlaceReservedId;

			if (oldBoardgameId is not null)
			{
				Boardgame oldBoardgame = await context.Boardgames.FindAsync(oldBoardgameId);
				oldBoardgame.IsReserved = false;
				oldBoardgame.ReservationId = null;
			}

			var oldPlace = await context.ReservationPlaces.FindAsync(oldPlaceReservedId);
			oldPlace.IsReserved = false;
			oldPlace.ReservationId = null;

			var newBoardgame = await context.Boardgames.FirstOrDefaultAsync(b => b.Id == reservation.BoardgameReservedId);
			if(newBoardgame != null)
			{
				newBoardgame.IsReserved = true;
				newBoardgame.ReservationId = reservation.Id;
			}

			var newPlace = await context.ReservationPlaces.FindAsync(reservation.ReservationPlaceId);
			newPlace.IsReserved = true;
			newPlace.ReservationId = reservation.Id;

			await context.SaveChangesAsync();
		}

        public async Task<ReservationDeleteFormModel> GetDeleteFormAsync(Reservation reservation)
		{
			var form = new ReservationDeleteFormModel()
			{
				Id = reservation.Id,
				ReservationName = $"{reservation.ReservationOwner.FirstName}'s reservation",
				DateTime = reservation.DateTime
			};

			return form;
		}

		public async Task DeleteConfirmedAsync(ReservationDeleteFormModel form)
		{
			Reservation reservation = await GetReservationAsync(form.Id);

			reservation.ReservationPlace.IsReserved = false;
			reservation.ReservationPlace.ReservationId = null;

			Boardgame? boardgameReserved = await context.Boardgames.FindAsync(reservation.BoardgameReservedId);

			if(boardgameReserved != null)
			{
                boardgameReserved.IsReserved = false;
                boardgameReserved.ReservationId = null;
            }

			context.Reservations.Remove(reservation);
			await context.SaveChangesAsync();
		}
		public async Task<IEnumerable<ReservationViewModel>> GetAllExpiredAsync()
		{
			return await context.Reservations
				.Include(r => r.ReservationOwner)
				.Where(r => r.DateTime.Day < DateTime.Now.Day
				&& r.IsExpired == false)
				.AsNoTracking()
				.OrderByDescending(r => r.DateTime)
				.Select(r => new ReservationViewModel()
				{
					Id = r.Id,
					ReservationImage = ReservationImagePath,
					ReservationName = $"{r.ReservationOwner.FirstName}'s reservation",
					DateTime = r.DateTime.ToString(ReservationDateTimeFormat)
				})
				.ToListAsync();
		}
		public async Task FreeTablesAsync(int reservationId)
		{
			Reservation reservation = await GetReservationAsync(reservationId);

			reservation.ReservationPlace.IsReserved = false;
			reservation.ReservationPlace.ReservationId = null;


			Boardgame? boardgameReserved = await context.Boardgames.FindAsync(reservation.BoardgameReservedId);

			if (boardgameReserved != null)
			{
				boardgameReserved.IsReserved = false;
				boardgameReserved.ReservationId = null;
			}

			reservation.IsExpired = true;

			await context.SaveChangesAsync();
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
				.AsNoTracking()
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
					.Include(rp => rp.PlaceType)
					.AsNoTracking()
					.Where(rp => rp.IsReserved == false)
					.Select(rp => new ReservationPlaceViewModel()
					{
						Id = rp.Id,
						Name = rp.Name,
					})
					.ToListAsync();
		}

		public async Task<Reservation> GetReservationAsync(int id)
		{
			return await context.Reservations
				.Include(r => r.BoardgameReserved)
				.Include(r => r.ReservationPlace)
				.Include(r => r.ReservationOwner)
				.FirstOrDefaultAsync(r => r.Id == id);
		}

		public async Task<bool> UserHasReservation(string userId, DateTime dateTime)
		{
			return await context.Reservations
				.AnyAsync(r => r.ReservationOwnerId == userId
				&& r.DateTime.Day == dateTime.Day);
		}

		public async Task<IEnumerable<ReservationViewModel>> GetAllActiveAsync()
		{
			return await context.Reservations
				.Include(r => r.ReservationOwner)
				.Where(r => r.DateTime.Day >= DateTime.Now.Day)
				.AsNoTracking()
                .OrderBy(r => r.DateTime)
                .Select(r => new ReservationViewModel()
				{
					Id = r.Id,
					ReservationImage = ReservationImagePath,
					ReservationName = $"{r.ReservationOwner.FirstName}'s reservation",
					DateTime = r.DateTime.ToString(ReservationDateTimeFormat)
				})
				.ToListAsync();
		}
	}
}
