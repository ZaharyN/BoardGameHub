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
			throw new NotImplementedException();
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


			throw new NotImplementedException();	
		}
	}
}
