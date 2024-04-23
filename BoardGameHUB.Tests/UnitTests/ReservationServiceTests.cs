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
                DateTime = new DateTime(2024,12,10),
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

            Assert.AreEqual(Reservation1,reservationFound);
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
                DateTime = new DateTime(2025, 12,12)
            };

            await context.Reservations.AddAsync(newReservation);

            int activeReservations =
                await context.Reservations.CountAsync(r => r.DateTime.Date >= DateTime.Now);

            var activerReservationsFromService = await reservationService.GetAllActiveAsync();

            Assert.AreEqual(activeReservations, activerReservationsFromService.Count());
        }

    }
}
