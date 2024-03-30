using BoardGameHub.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoardGameHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("All", nameof(BoardgameController));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
