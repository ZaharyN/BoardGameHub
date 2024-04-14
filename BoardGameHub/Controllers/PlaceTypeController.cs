using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.PlaceTypeViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Controllers
{
    public class PlaceTypeController : Controller
    {
        private readonly IPlaceTypeService placeTypeService;

        public PlaceTypeController(IPlaceTypeService _placeTypeService)
        {
            placeTypeService = _placeTypeService;
        }

        public async Task<IActionResult> ViewAll()
        {
            IEnumerable<PlaceTypeViewModel> models = await placeTypeService.GetAllAsync();

            return View(models);
        }
    }
}
