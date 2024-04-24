using AutoMapper.Configuration.Conventions;
using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.GameReviewViewModel;
using BoardGameHub.Core.Services;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHUB.Tests.UnitTests
{
    [TestFixture]
    public class GameReviewServiceTests : UnitTestsBase
    {
        private IGameReviewService gameReviewService;
        private IBoardgameService boardgameService;

        [OneTimeSetUp]
        public void SetUp()
        {
            boardgameService = new BoardgameService(context);
            gameReviewService = new GameReviewService(context, boardgameService);
        }

        [Test]
        public async Task GetCreateFromShouldReturnTheCorrectBoardgameInformation()
        {
            int id = Dune.Id;
            string name = Dune.Name;

            var form = await gameReviewService.GetCreateFormAsync(Dune.Id);

            Assert.AreEqual(id, form.BoardgameId);
            Assert.AreEqual(name, form.BoardgameName);
        }

        [Test]
        public async Task CreateAsyncShouldAddNewGameReview()
        {
            int gameReviewsBeforeCount = await context.GameReviews.CountAsync();

            GameReviewCreateFormModel form = new()
            {
                BoardgameId = Dune.Id,
                BoardgameName = Dune.Name,
                ReviewText = "This is the new review"
            };

            await gameReviewService.CreateAsync(form, Dune.Id, AppUser1.Id);

            int gameReviewsAfterCount = await context.GameReviews.CountAsync();

            Assert.AreEqual(gameReviewsBeforeCount + 1, gameReviewsAfterCount);
        }

        [Test]
        public async Task CreateAsyncShouldAddTHeGameReviewToTheBoardgame()
        {
            int boardgameReviewsBefore = Dune.GameReviews.Count();

            GameReviewCreateFormModel form = new()
            {
                BoardgameId = Dune.Id,
                BoardgameName = Dune.Name,
                ReviewText = "This is the new review"
            };

            await gameReviewService.CreateAsync(form, Dune.Id, AppUser1.Id);

            int boardgameReviewsAfter = Dune.GameReviews.Count();

            Assert.AreEqual(boardgameReviewsBefore + 1, boardgameReviewsAfter);
        }

        [Test]
        public async Task UserHasCommentsShouldWorkProperly()
        {
            string user1Id = AppUser1.Id;
            string user2Id = AppUser2.Id;

            bool DuneHasCommentByUser1 = Dune.GameReviews.Any(gr => gr.ReviewOwnerId == AppUser1.Id);
            bool DuneHasCommentByUser2 = Dune.GameReviews.Any(gr => gr.ReviewOwnerId == AppUser2.Id);

            bool result1 = await gameReviewService.UserHasComment(user1Id, Dune.Id);
            bool result2 = await gameReviewService.UserHasComment(user2Id, Dune.Id);

            Assert.AreEqual(result1, DuneHasCommentByUser1);
            Assert.AreEqual(result2, DuneHasCommentByUser2);
        }
    }
}
