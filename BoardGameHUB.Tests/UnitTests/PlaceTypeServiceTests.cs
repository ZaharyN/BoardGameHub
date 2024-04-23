using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BoardGameHUB.Tests.UnitTests
{
    public class PlaceTypeServiceTests : UnitTestsBase
    {
        private IPlaceTypeService placeTypeService;

        [OneTimeSetUp]
        public void SetUp() => placeTypeService = new PlaceTypeService(context);

        [Test]
        public async Task GetAllShouldReturnAllThePlaceTypes()
        {
            int placeTypesCount = await context.PlaceTypes.CountAsync();

            var models = await placeTypeService.GetAllAsync();

            Assert.AreEqual(placeTypesCount, models.Count());
        }

        [Test]
        public async Task GetAllShouldReturnAllThePlaceTypesAfterAddingNewOne()
        {
            PlaceType newPlace = new()
            {
                Name = "Largest table",
                Capacity = 20,
                PricePerHour = 50.00M
            };
            await context.PlaceTypes.AddAsync(newPlace);    

            int placeTypesCount = await context.PlaceTypes.CountAsync();

            var models = await placeTypeService.GetAllAsync();

            Assert.AreEqual(placeTypesCount, models.Count());
        }
    }
}
