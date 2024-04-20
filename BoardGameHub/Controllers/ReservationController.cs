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
		public async Task<IActionResult> Mine()
		{
			string userId = GetUser();

			var reservations = await reservationService.MineAsync(userId);

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

			if(dateTime <= DateTime.Now)
			{
				ModelState.AddModelError(form.DateTime, $"Invalid date! Date must be after {DateTime.Now.ToString(ReservationDateTimeFormat)}");

				form.FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync();
				form.FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync();

				return View(form);
			}

			string userId = GetUser();
			if (await reservationService.UserHasReservation(userId, dateTime))
			{
				ModelState.AddModelError(form.DateTime, $"Invalid date! User already has a reservation for this day!");
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

			await reservationService.CreateReservationAsync(form, userId, dateTime);

			return RedirectToAction(nameof(Mine));
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var reservation = await reservationService.GetReservationAsync(id);

			if(reservation == null)
			{
				return BadRequest();
			}

			string userId = GetUser();

			var model = await reservationService.ReservationDetailsAsync(reservation, userId);

			return View(model);
		}

		private string GetUser()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
		}
	}
}
