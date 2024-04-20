using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Claims;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class ReservationController : AdminBaseController
	{
		private readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService,
			IBoardgameService _boardgameService)
        {
            reservationService = _reservationService;
        }

		[HttpGet]
        public async Task<IActionResult> All()
		{
			var reservations = await reservationService.GetAllActiveAsync();

			return View(reservations);
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			if (await reservationService.GetReservationAsync(id) == null)
			{
				return BadRequest();
			}

			var form = await reservationService.GetEditFormAsync(id);

			if(form == null)
			{
				return BadRequest();
			}

			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(ReservationEditFormModel form)
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

			if (dateTime <= DateTime.Now)
			{
				ModelState.AddModelError(form.DateTime, $"Invalid date! Date must be after {DateTime.Now.ToString(ReservationDateTimeFormat)}");

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

			await reservationService.EditAsync(form, dateTime);

			return RedirectToAction("Details", "Reservation", new { area = "", id = form.Id });
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

			await reservationService.DeleteConfirmedAsync(form);

			return RedirectToAction(nameof(All));
		}

		[HttpGet]
		public async Task<IActionResult> Expired()
		{
			var expired = await reservationService.GetAllExpiredAsync();

			return View(expired);
		}

		[HttpPost]
		public async Task<IActionResult> FreePlaces(int id)
		{
			await reservationService.FreeTablesAsync(id);

			return View();
		}
	}
}
