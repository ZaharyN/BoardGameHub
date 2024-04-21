using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			if (statusCode == 400)
			{
				return View("Error400");
			}

			if (statusCode == 401)
			{
				return View("Error401");
			}

			return View();
		}
	}
}
