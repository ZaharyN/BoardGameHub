using BoardGameHub.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class ReservationController : AdminBaseController
	{
		private readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

		[HttpGet]
        public async Task<IActionResult> All()
		{
			var reservations = await reservationService.GetAllAsync();

			return View(reservations);
		}
	}
}
