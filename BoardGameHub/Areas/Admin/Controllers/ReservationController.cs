using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class ReservationController : AdminBaseController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
