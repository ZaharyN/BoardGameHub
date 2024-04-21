using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.PlaceTypeViewModel;
using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Core.Services
{
    public class PlaceTypeService : IPlaceTypeService
    {
        private readonly BoardGameHubDbContext context;

        public PlaceTypeService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<PlaceTypeViewModel>> GetAllAsync()
        {
            var models = await context.PlaceTypes
                .Select(pt => new PlaceTypeViewModel()
                {
                    Name = pt.Name,
                    Capacity = pt.Capacity,
                    PricePerHour = pt.PricePerHour
                })
                .ToArrayAsync();

            return models;
        }
    }
}
