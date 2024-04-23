using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Core.Services;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

            Assert.That(serviceResult.Count(), Is.EqualTo(categoriesCount));
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

        [Test]
        public async Task GetCreateFormShouldReturnFormWithAllCategories()
        {
            var allCategories = context.Categories.Count();

            var form = await boardgameService.GetCreateFormAsync();

            Assert.AreEqual(allCategories, form.Categories.Count());
        }

        [Test]
        public async Task CreateMethodShouldAddNewBoardgame()
        {
            //Arrange

            int allBoardgamesBefore = context.Boardgames.Count();

            var content = "This is the image content";
            var cardFileName = "card_image.jpg";
            var detailsFileName = "details_image.jpg";
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(content);
            writer.Flush();
            stream.Position = 0;

            IFormFile cardFile = new FormFile(stream, 0, stream.Length, "id_from_form", cardFileName);
            IFormFile detailsFile = new FormFile(stream, 0, stream.Length, "id_from_form", detailsFileName);

            //Act

            BoardgameCreateFormModel form = new()
            {
                Name = "Catan",
                AppropriateAge = 10,
                AveragePlayingTime = 90,
                Rating = 2,
                Description = "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.",
                Difficulty = 2,
                CardImage = cardFile,
                DetailsImage = detailsFile,
                YearPublished = 1995,
                PriceInShop = 50.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 4,
                IsUpcoming = false,
                SelectedCategoriesId = new List<int> { 1, 2 }
            };

            await boardgameService.CreateAsync(form);

            int allBoardgamesAfter = context.Boardgames.Count();

            //Assert

            Assert.AreEqual(allBoardgamesBefore + 1, allBoardgamesAfter);
        }

        [Test]
        public async Task CreateMethodShouldAddNewBoardgameWithCorrectData()
        {
            int allBoardgamesBefore =await context.Boardgames.CountAsync();

            var content = "This is the image content";
            var cardFileName = "card_image.jpg";
            var detailsFileName = "details_image.jpg";
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(content);
            writer.Flush();
            stream.Position = 0;

            IFormFile cardFile = new FormFile(stream, 0, stream.Length, "id_from_form", cardFileName);
            IFormFile detailsFile = new FormFile(stream, 0, stream.Length, "id_from_form", detailsFileName);

            BoardgameCreateFormModel form = new()
            {
                Name = "Catan",
                AppropriateAge = 10,
                AveragePlayingTime = 90,
                Rating = 2,
                Description = "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.",
                Difficulty = 2,
                CardImage = cardFile,
                DetailsImage = detailsFile,
                YearPublished = 1995,
                PriceInShop = 50.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 4,
                IsUpcoming = false,
                SelectedCategoriesId = new List<int> { 1, 2 }
            };

            await boardgameService.CreateAsync(form);

            var newBoardgame = await context.Boardgames.LastAsync();

            Assert.AreEqual(newBoardgame.Name, "Catan");
            Assert.AreEqual(newBoardgame.IsReserved, false);
        }

        [Test]
        public async Task DetailsMethodShouldReturnTheCorrectBoardgame()
        {
            int duneId = Dune.Id;

            BoardgameDetailsViewModel model = await boardgameService.DetailsAsync(duneId);

            Assert.AreEqual(duneId, model.Id);
            Assert.AreEqual(Dune.Name, model.Name);
            Assert.AreEqual(Dune.Rating, model.Rating);
        }

        [Test]
        public async Task DetailsMethodShouldReturnReviewOwnerAndBoardgameCategories()
        {
            int duneId = Dune.Id;

            BoardgameDetailsViewModel model = await boardgameService.DetailsAsync(duneId);

            Assert.IsNotNull(model.BoardgameCategories);
            Assert.IsNotNull(model.GameReviews);
        }

        [Test]
        public async Task DetailsMethodShouldThrowExceptionIfNoBoardgamExists()
        {
            int notExistentId = 100;
            bool exceptionThrown = false;

            try
            {
                var result = await boardgameService.DetailsAsync(notExistentId);
            }
            catch (ArgumentException ex)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }

        [Test]
        public async Task GetEditMethodShouldReturnBoardgameWithTheSameProeprties()
        {
            var model = await boardgameService.GetEditFormAsync(Dune);

            Assert.AreEqual(Dune.Name, model.Name);
            Assert.AreEqual(Dune.Rating, model.Rating);
        }

        [Test]
        public async Task EditShouldChangeTheProperties()
        {
            BoardgameEditFormModel form = new()
            {
                Id = Dune.Id,
                Name = "Dune edited",
                Categories = await boardgameService.AllCategoriesAsync(),
                Rating = 5,
                AppropriateAge = Dune.AppropriateAge,
                AveragePlayingTime = Dune.AveragePlayingTime,
                Description = Dune.Description,
                Difficulty = Dune.Difficulty,
                YearPublished = Dune.YearPublished,
                PriceInShop = Dune.PriceInShop,
                MinimumPlayersAllowedToPlay = Dune.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = Dune.MaximumPlayersAllowedToPlay,
                IsUpcoming = Dune.IsUpcoming,
                NewCategoriesId = new List<int> { 2, 3 }
            };

            await boardgameService.EditAsync(form, Dune);

            Assert.AreEqual(form.Id, Dune.Id);
            Assert.AreEqual(form.Name, Dune.Name);
            Assert.AreEqual(form.Rating, Dune.Rating);
        }

        [Test]  
        public async Task EditMethodShouldChangeTheBoardgameCategories()
        {
            BoardgameEditFormModel form = new()
            {
                Id = Dune.Id,
                Name = "Dune edited",
                Categories = await boardgameService.AllCategoriesAsync(),
                Rating = 5,
                AppropriateAge = Dune.AppropriateAge,
                AveragePlayingTime = Dune.AveragePlayingTime,
                Description = Dune.Description,
                Difficulty = Dune.Difficulty,
                YearPublished = Dune.YearPublished,
                PriceInShop = Dune.PriceInShop,
                MinimumPlayersAllowedToPlay = Dune.MinimumPlayersAllowedToPlay,
                MaximumPlayersAllowedToPlay = Dune.MaximumPlayersAllowedToPlay,
                IsUpcoming = Dune.IsUpcoming,
                NewCategoriesId = new List<int> { 3 }
            };

            await boardgameService.EditAsync(form, Dune);

            Assert.AreEqual(Dune.BoardgamesCategories.Count(), form.NewCategoriesId.Count());

            var contextCategory = await context.Categories.SingleOrDefaultAsync(c => c.Id == 3);
            var boardgameCategory = Dune.BoardgamesCategories.Select(bc => bc.Category).FirstOrDefault();

            Assert.AreEqual(contextCategory.Name, boardgameCategory.Name);
        }

        [Test]
        public async Task ExistsAsyncShouldWorkProperly()
        {
            int duneId = Dune.Id;

            Boardgame expected = await boardgameService.ExistsAsync(duneId);

            Assert.AreEqual(expected, Dune);
            Assert.AreEqual(expected.Id, Dune.Id);
        }

        [Test]
        public async Task ExistsAsyncShouldReturnNullIfNoBoardgameExists()
        {
            int nonExistingId = 100;

            Boardgame exptected = await boardgameService.ExistsAsync(nonExistingId);

            Assert.AreEqual(exptected, null);
        }

        [Test]
        public async Task GetDeleteFormShouldReturnProperIdAndName()
        {
            int duneId = Dune.Id;
            string duneName = Dune.Name;

            var form = await boardgameService.GetDeleteFormAsync(Dune);

            Assert.AreEqual(duneId, form.Id);
            Assert.AreEqual(duneName, form.Name);
        }

        [Test]
        public async Task DeleteConfirmedSHouldRemoveBoardgame()
        {
            int boardgamesBeforeDelete = await context.Boardgames.CountAsync();

            await boardgameService.DeleteAsync(Dune);

            int boardgamesAfterDelete = await context.Boardgames.CountAsync();

            Assert.AreEqual(boardgamesAfterDelete, boardgamesBeforeDelete - 1);
        }

        [Test]
        public async Task DeleteShouldRemoveTheBoardgameCateriesAndGameReviews()
        {
            await boardgameService.DeleteAsync(Dune);

            var deleteBoardgameReviews = await context.GameReviews.Where(gr => gr.BoardGameId == Dune.Id).ToListAsync();

            Assert.AreEqual(deleteBoardgameReviews.Count(), 0);

            var deleteBoardgameCategories = await context.BoardgamesCategories.Where(bc => bc.BoardgameId == Dune.Id).ToListAsync();

            Assert.AreEqual(deleteBoardgameCategories.Count(), 0);
        }
    }
}
