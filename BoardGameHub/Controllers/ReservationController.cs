using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
			if (!ModelState.IsValid)
			{
				form.BoardgamesReserved = await reservationService.GetAllFreeBoardgamesAsync();
				form.FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync();

				return View();
			}

			string userId = GetUser();

			await reservationService.CreateReservationAsync(form, userId);

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

		private string GetUser()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
		}
	}
}
