using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
