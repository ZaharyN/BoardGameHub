﻿using BoardGameHub.Core.Contracts;
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

		public async Task CreateReservationAsync(ReservationCreateFormModel form, string userId, DateTime dateTime)
		{
			List<ReservationPlace> placesReserved = new List<ReservationPlace>();

			foreach (var resPlaceId in form.PlacesReserved)
			{
				ReservationPlace currentPlace = await context.ReservationPlaces.FindAsync(resPlaceId);

				if (currentPlace != null)
				{
					placesReserved.Add(currentPlace);
				}
			}

			Boardgame? boardgameReserved = await context.Boardgames.FindAsync(form.BoardgameReservedId);

			Reservation reservation = new Reservation()
			{
				ReservationOwnerId = userId,
				DateTime = dateTime,
				AdditionalComment = form.AdditionalComment,
				ReservationPlaces = placesReserved,
				BoardgameReservedId = boardgameReserved.Id,
				BoardgameReserved = boardgameReserved
			};

			foreach (var resPlace in reservation.ReservationPlaces)
			{
				resPlace.IsReserved = true;
				resPlace.ReservationId = reservation.Id;
			}

			if(boardgameReserved != null)
			{
				boardgameReserved.IsReserved = true;
			}

			context.Reservations.Add(reservation);
			await context.SaveChangesAsync();
		}

		public async Task<IEnumerable<ReservationViewModel>> MineAsync(string id)
		{
			string userName = GetUser(id).Result.FirstName;

			var reservations = await context.Reservations
				.Where(r => r.ReservationOwnerId == id)
				.Select(r => new ReservationViewModel()
				{
					Id = r.Id,
					ReservationImage = "/assets/Reservation/Reservation_image.jpg",
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
				BoardgameReservedName = reservation.BoardgameReserved.Name
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

			Boardgame? boardgameReserved = await context.Boardgames.FindAsync(reservation.BoardgameReservedId);

			if(boardgameReserved != null)
			{
				boardgameReserved.IsReserved = false;
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
			return await context.Reservations.FindAsync(id);
		}

		public async Task<bool> UserHasReservation(string userId, DateTime dateTime)
		{
			return await context.Reservations
				.AnyAsync(r => r.ReservationOwnerId == userId
				&& r.DateTime.Day == dateTime.Day);
		}
	}

}
