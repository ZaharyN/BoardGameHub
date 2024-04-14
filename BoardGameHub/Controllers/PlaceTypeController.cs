using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
    public class PlaceTypeController : Controller
    {
        public IActionResult ViewAll()
        {
            return View();
        }
    }
}
