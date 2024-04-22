using AutoMapper.Configuration.Conventions;
using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;

namespace BoardGameHUB.Tests.UnitTests
{
    [TestFixture]
    public class BoardgameServiceTests : UnitTestsBase
    {
        private IBoardgameService boardgameService;

        [OneTimeSetUp]
        public void SetUp() => boardgameService = new BoardgameService(context);

        [Test]
        public async Task ActiveMethodShouldReturnAllNotUpcomingBoardgames()
        {
            int activeBoardgames = context.Boardgames.Count(b => b.IsUpcoming == false);

            var serviceResult = await boardgameService.ActiveAsync();

            Assert.AreEqual(activeBoardgames, serviceResult.Count());
        }

        [Test]
        public async Task UpcomingMethodShouldReturnAllUpcomingBoardgames()
        {
            int upcomingBoardgames = context.Boardgames.Count(b => b.IsUpcoming);

            var serviceResult = await boardgameService.UpcomingAsync();

            Assert.AreEqual(upcomingBoardgames, serviceResult.Count());
        }

        [Test]
        public async Task ActiveMethodAfterChangingStatusToOneBoardgame()
        {
            int activeBoardgames = context.Boardgames.Count(b => b.IsUpcoming == false);

            var serviceResult = await boardgameService.ActiveAsync();

            Assert.AreEqual(activeBoardgames, serviceResult.Count());

            Dune.IsUpcoming = true;

            int activeBoardgamesAfterStatusChange = context.Boardgames.Count(b => b.IsUpcoming == false);

            var serviceResultAfterStatusChange = await boardgameService.ActiveAsync();

            Assert.AreEqual(activeBoardgamesAfterStatusChange, serviceResultAfterStatusChange.Count());
        }

        [Test]
        public async Task UpcomingMethodAfterChangingStatusToOneBoardgame()
        {
            int upcomingBoardgames = context.Boardgames.Count(b => b.IsUpcoming);

            var serviceResult = await boardgameService.UpcomingAsync();

            Assert.AreEqual(upcomingBoardgames, serviceResult.Count());

            EclipseSecondDawnForTheGalaxyBoardgame.IsUpcoming = false;

            int upcomingBoardgamesAfterStatusChange = context.Boardgames.Count(b => b.IsUpcoming);

            var serviceResultAfterStatusChange = await boardgameService.UpcomingAsync();

            Assert.AreEqual(upcomingBoardgamesAfterStatusChange, serviceResultAfterStatusChange.Count());
        }

        [Test]
        public async Task PromoteToActiveShouldWorkProperly()
        {
            Dune.IsUpcoming = true;

            await boardgameService.PromoteToActiveAsync(Dune.Id);

            Assert.IsFalse(Dune.IsUpcoming);
        }

        [Test]
        public async Task PromoteToActiveShouldNotChangeStatusIfItIsActive()
        {
            Dune.IsUpcoming = false;

            await boardgameService.PromoteToActiveAsync(Dune.Id);

            Assert.IsFalse(Dune.IsUpcoming);
        }

        [Test]
        public async Task AllCategoriesShouldReturnAllCategories()
        {
            int categoriesCount = context.Categories.Count();

            var serviceResult = await boardgameService.AllCategoriesAsync();

            Assert.AreEqual(categoriesCount, serviceResult.Count());
        }

        [Test]
        public async Task AllCategoriesShouldReturnProperResultAfterDeletion()
        {
            int categoriesCount = context.Categories.Count();

            var serviceResult = await boardgameService.AllCategoriesAsync();

            Assert.AreEqual(categoriesCount, serviceResult.Count());

            context.Categories.Remove(Category1);

            int categoriesCountAfterDeletion = context.Categories.Count();

            var serviceResultAfterDeletion = await boardgameService.AllCategoriesAsync();

            Assert.AreEqual(categoriesCountAfterDeletion, serviceResultAfterDeletion.Count());
        }


    }
}
