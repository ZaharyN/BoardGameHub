using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Claims;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Controllers
{
	[Authorize]
	public class ReservationController : Controller
	{
		private readonly IReservationService reservationService;
        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

		[HttpGet]
		public async Task<IActionResult> MyReservations()
		{
			string userId = GetUser();

			var reservations = await reservationService.MyReservationsAsync(userId);

			return View(reservations);
		}

        [HttpGet]
		public async Task<IActionResult> Create()
		{
			ReservationCreateFormModel form 
				= await reservationService.GetCreateReservationFormAsync();

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> Create(ReservationCreateFormModel form)
		{
            if (!DateTime.TryParseExact(form.DateTime,
                ReservationDateTimeFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime dateTime))
            {
				ModelState.AddModelError(form.DateTime, $"Invalid date! Format must be: {ReservationDateTimeFormat}");

				form.FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync();
				form.FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync();

				return View(form);
			}

            if (!ModelState.IsValid)
			{
				form.FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync();
				form.FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync();

				return View(form);
			}

			string userId = GetUser();

			if(await reservationService.UserHasReservation(userId, dateTime))
			{
				ModelState.AddModelError(form.DateTime, $"Invalid date! Format must be: {ReservationDateTimeFormat}");

				form.FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync();
				form.FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync();
				return View(form);
			}

			await reservationService.CreateReservationAsync(form, userId, dateTime);

			return RedirectToAction(nameof(MyReservations));
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var reservation = await reservationService.GetReservationAsync(id);

			if(reservation == null)
			{
				return BadRequest();
			}

			var model = await reservationService.ReservationDetailsAsync(reservation);

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			var reservation = await reservationService.GetReservationAsync(id);

			if (reservation == null)
			{
				return BadRequest();
			}

			var form = await reservationService.GetDeleteFormAsync(reservation);

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmed(ReservationDeleteFormModel form)
		{
			if (form == null)
			{
				return BadRequest();
			}
			
			if(await reservationService.GetReservationAsync(form.Id) == null)
			{
				return NotFound();
			}

			await reservationService.DeleteConfirmedAsync(form);

			return RedirectToAction(nameof(MyReservations));
		}

		private string GetUser()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
		}
	}
}
