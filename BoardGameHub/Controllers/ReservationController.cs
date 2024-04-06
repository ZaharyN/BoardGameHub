using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
	public class ReservationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
