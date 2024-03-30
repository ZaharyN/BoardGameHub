using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
    [Authorize]
    public class BoardgameController : Controller
    {
        
        public async Task<IActionResult> All()
        {
            return View();
        }

        public async Task<IActionResult> Upcoming()
        {
            return View();
        }
    }
}
