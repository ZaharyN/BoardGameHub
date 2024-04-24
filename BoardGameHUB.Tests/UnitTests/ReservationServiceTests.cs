using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.ReservationViewModel;
using BoardGameHub.Core.Services;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHUB.Tests.UnitTests
{
    [TestFixture]
    public class ReservationServiceTests : UnitTestsBase
    {
        private IReservationService reservationService;

        [OneTimeSetUp]
        public void SetUp() => reservationService = new ReservationService(context);


        [Test]
        public async Task GetCreateReservationFormShouldHaveAllFreeBoardgames()
        {
            int freeBoardgames = await context.Boardgames.CountAsync(b => b.IsReserved == false && b.IsUpcoming == false);

            var form = await reservationService.GetCreateReservationFormAsync();

            Assert.AreEqual(freeBoardgames, form.FreeBoardgames.Count);
        }

        [Test]
        public async Task GetCreateReservationFormShouldHaveAllFreePlaces()
        {
            int freePlaces = await context.ReservationPlaces.CountAsync(rp => rp.IsReserved == false);

            var form = await reservationService.GetCreateReservationFormAsync();

            Assert.AreEqual(freePlaces, form.FreePlaces.Count);
        }

        [Test]
        public async Task CreateReservationShouldAddNewReservation()
        {
            int reservationCountBefore = await context.Reservations.CountAsync();

            string userId = AppUser1.Id;
            DateTime datetime = new DateTime(2024, 04, 24, 20, 30, 00);

            ReservationCreateFormModel form = new()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                PhoneNumber = "0896778523",
                DateTime = "12.12.2024 20:00",
                AdditionalComment = "Table next to the window",
                BoardgameReservedId = 1,
                PlaceReservedId = 2,
                FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync(),
                FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync()
            };

            await reservationService.CreateReservationAsync(form, userId, datetime);

            int reservationCountAfter = await context.Reservations.CountAsync();

            Assert.AreEqual(reservationCountBefore + 1, reservationCountAfter);
        }

        [Test]
        public async Task CreateReservationShouldCrateWithTheCorrectValues()
        {
            string userId = AppUser1.Id;
            DateTime datetime = new DateTime(2024, 04, 24, 20, 30, 00);

            ReservationCreateFormModel form = new()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                PhoneNumber = "0896778525",
                DateTime = "24-04-2024 20:30",
                AdditionalComment = "Table next to the window",
                BoardgameReservedId = 1,
                PlaceReservedId = 2,
                FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync(),
                FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync()
            };

            await reservationService.CreateReservationAsync(form, userId, datetime);

            var reservation = await context.Reservations.LastAsync();

            Assert.AreEqual(form.PhoneNumber, reservation.PhoneNumber);
            Assert.AreEqual(form.AdditionalComment, reservation.AdditionalComment);
        }

        [Test]
        public async Task CreateReservationShouldAddReservationIdToChosenBoardgame()
        {
            string userId = AppUser1.Id;
            DateTime datetime = new DateTime(2024, 04, 24, 20, 30, 00);

            ReservationCreateFormModel form = new()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                PhoneNumber = "0896778525",
                DateTime = "24-04-2024 20:30",
                AdditionalComment = "Table next to the window",
                BoardgameReservedId = 1,
                PlaceReservedId = 2,
                FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync(),
                FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync(),
            };

            await reservationService.CreateReservationAsync(form, userId, datetime);

            var reservation = await context.Reservations.LastAsync();

            Assert.AreEqual(Dune.ReservationId, reservation.Id);
        }

        [Test]
        public async Task CreateReservationShouldChangeReservationPlaceStatusToIsReserved()
        {
            string userId = AppUser1.Id;
            DateTime datetime = new DateTime(2024, 04, 24, 20, 30, 00);

            ReservationCreateFormModel form = new()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                PhoneNumber = "0896778525",
                DateTime = "24-04-2024 20:30",
                AdditionalComment = "Table next to the window",
                BoardgameReservedId = 1,
                PlaceReservedId = 2,
                FreeBoardgames = await reservationService.GetAllFreeBoardgamesAsync(),
                FreePlaces = await reservationService.GetAllFreeReservationPlacesAsync(),
            };

            await reservationService.CreateReservationAsync(form, userId, datetime);
            var reservation = await context.Reservations.LastAsync();

            Assert.IsTrue(ReservationPlace2.IsReserved);
            Assert.AreEqual(ReservationPlace2.ReservationId, reservation.Id);
        }

        [Test]
        public async Task MineShouldReturnOnlyReservationsForTheSameUser()
        {
            string userId = AppUser1.Id;

            int userReservations = await context.Reservations.Where(r => r.ReservationOwnerId == userId).CountAsync();
            var reservationsFromService = await reservationService.MineAsync(userId);

            Assert.AreEqual(userReservations, reservationsFromService.Count());
        }

        [Test]
        public async Task MineShouldReturnOnlyReservationsForTheSameUserAfterAddingNew()
        {
            string userId = AppUser1.Id;

            Reservation newReservation = new()
            {
                ReservationOwnerId = userId
            };

            await context.Reservations.AddAsync(newReservation);

            int userReservations = await context.Reservations.Where(r => r.ReservationOwnerId == userId).CountAsync();
            var reservationsFromService = await reservationService.MineAsync(userId);

            Assert.AreEqual(userReservations, reservationsFromService.Count());
        }

        [Test]
        public async Task ReservationDetailsShouldReturnTheCorrectValues()
        {
            Reservation reservation = new()
            {
                Id = 5,
                ReservationOwner = AppUser1,
                ReservationOwnerId = AppUser1.Id,
                DateTime = new DateTime(2024, 12, 10),
                AdditionalComment = "Add comment",
                PhoneNumber = "0896778484",
                ReservationPlaceId = 2,
                BoardgameReservedId = null,
                IsExpired = false
            };

            await context.Reservations.AddAsync(reservation);

            var model = await reservationService.ReservationDetailsAsync(reservation);

            Assert.AreEqual($"{reservation.ReservationOwner.FirstName}'s reservation", model.ReservationName);
            Assert.AreEqual(reservation.PhoneNumber, model.PhoneNumber);
            Assert.AreEqual(reservation.DateTime.ToString("dd-MM-yyyy HH:mm"), model.DateTime);
            Assert.AreEqual("None", model.BoardgameReservedName);
        }

        [Test]
        public async Task GetEditFormShouldReturnTheSameValuesAsOriginal()
        {
            int reservationId = Reservation1.Id;

            var reservationEditForm = await reservationService.GetEditFormAsync(reservationId);

            Assert.AreEqual(Reservation1.Id, reservationEditForm.Id);
            Assert.AreEqual(Reservation1.PhoneNumber, reservationEditForm.PhoneNumber);
            Assert.AreEqual(Reservation1.AdditionalComment, reservationEditForm.AdditionalComment);
            Assert.AreEqual(Reservation1.BoardgameReservedId, reservationEditForm.BoardgameReservedId);
        }

        [Test]
        public async Task GetReservationInGetEditShouldFindTheExactReservation()
        {
            var reservationFound = await reservationService.GetReservationAsync(Reservation1.Id);

            Assert.AreEqual(Reservation1, reservationFound);
        }

        [Test]
        public async Task GetAllActiveShouldWorkProperly()
        {
            int activeReservations =
                await context.Reservations.CountAsync(r => r.DateTime.Date >= DateTime.Now);

            var activerReservationsFromService = await reservationService.GetAllActiveAsync();

            Assert.AreEqual(activeReservations, activerReservationsFromService.Count());
        }

        [Test]
        public async Task GetAllActiveShouldWorkProperlyAfterAddingNewOne()
        {
            Reservation newReservation = new()
            {
                DateTime = new DateTime(2025, 12, 12)
            };

            await context.Reservations.AddAsync(newReservation);

            int activeReservations =
                await context.Reservations.CountAsync(r => r.DateTime.Date >= DateTime.Now);

            var activerReservationsFromService = await reservationService.GetAllActiveAsync();

            Assert.AreEqual(activeReservations, activerReservationsFromService.Count());
        }

        [Test]
        public async Task GetDeleteFormShouldReturnReservationWithCorrectInformation()
        {
            var form = await reservationService.GetDeleteFormAsync(Reservation2);

            Assert.AreEqual(Reservation2.Id, form.Id);
            Assert.AreEqual($"{Reservation2.ReservationOwner.FirstName}'s reservation", form.ReservationName);
        }

        [Test]
        public async Task DeleteShouldRemoveTheReservation()
        {
            int reservationCountBefore = await context.Reservations.CountAsync();

            ReservationDeleteFormModel deleteForm = new()
            {
                Id = Reservation1.Id
            };

            await reservationService.DeleteConfirmedAsync(deleteForm);

            int reservationCountAfter = await context.Reservations.CountAsync();

            Assert.AreNotEqual(reservationCountBefore, reservationCountAfter);
            Assert.AreEqual(reservationCountBefore, reservationCountAfter + 1);
        }

        [Test]
        public async Task DeleteShouldChangeBoardgameAndPlaceTypeStatusToNotReserved()
        {
            Reservation1.ReservationPlace.IsReserved = true;
            Reservation1.BoardgameReserved.IsReserved = true;

            ReservationDeleteFormModel deleteForm = new()
            {
                Id = Reservation1.Id
            };
            await reservationService.DeleteConfirmedAsync(deleteForm);

            Assert.IsFalse(Reservation1.ReservationPlace.IsReserved);
            Assert.IsFalse(Reservation1.BoardgameReserved.IsReserved);
            Assert.IsNull(Reservation1.BoardgameReserved.ReservationId);
        }

        [Test]
        public async Task GetAllExpiredShouldReturnTheCorrectAmount()
        {
            int expired = await context.Reservations
                .Where(r => r.DateTime <= DateTime.Now
                && r.IsExpired == false)
                .CountAsync();

            var serviceResult = await reservationService.GetAllExpiredAsync();

            Assert.AreEqual(expired, serviceResult.Count());
        }

        [Test]
        public async Task FreeTablesShouldWorkProperly()
        {
            Reservation1.BoardgameReserved.IsReserved = true;
            Reservation1.BoardgameReservedId = 1;

            Dune.ReservationId = 1;
            Dune.IsReserved = true;

            await reservationService.FreeTablesAsync(Reservation1.Id);

            Assert.IsFalse(Reservation1.ReservationPlace.IsReserved);
            Assert.IsNull(Reservation1.ReservationPlace.ReservationId);

            Assert.IsNull(Reservation1.BoardgameReserved);
            Assert.IsFalse(Dune.IsReserved);
            Assert.IsNull(Dune.ReservationId);
        }

        [Test]
        public async Task GetUserShouldReturnTheCorrectUser()
        {
            string user1Id = AppUser1.Id;

            var serviceResult = await reservationService.GetUser(user1Id);

            Assert.AreEqual(AppUser1, serviceResult);
        }

        [Test]
        public async Task GetUserShouldReturnNullIfTheIdIsNotValid()
        {
            string nullId = "nullId";

            var nullUser = await reservationService.GetUser(nullId);

            Assert.IsNull(nullUser);
        }

        [Test]
        public async Task UserHasReservationShouldWorkProperly()
        {
            Reservation newRes = new()
            {
                ReservationOwnerId = AppUser1.Id,
                DateTime = new DateTime(2024, 04, 10)
            };

            await context.Reservations.AddAsync(newRes);

            bool result = await reservationService.UserHasReservation(AppUser1.Id, new DateTime(2024, 04, 10));

            Assert.IsTrue(result);
        }
    }
}
