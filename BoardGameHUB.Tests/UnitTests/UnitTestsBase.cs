using AutoMapper;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using BoardGameHUB.Tests.Mocks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Bson;

namespace BoardGameHUB.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected BoardGameHubDbContext context;
        protected IMapper mapper;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            SeedDatabase();
        }

        public ApplicationUser AppUser1 { get; private set; }
        public ApplicationUser AppUser2 { get; private set; }
        public Boardgame Dune { get; private set; }
        public Boardgame TerraformMars { get; private set; }
        public BoardgameCategory DuneCategory1 { get; private set; }
        public BoardgameCategory TerraformMarsCategory1 { get; private set; }
        public BoardgameCategory DuneCategory2 { get; private set; }
        public BoardgameCategory TerraformMarsCategory2 { get; private set; }
        public BoardgameCategory TerraformMarsCategory3 { get; private set; }
        public Category Category1 { get; private set; }
        public Category Category2 { get; private set; }
        public Category Category3 { get; private set; }
        public GameReview GameReview1 { get; private set; }
        public GameReview GameReview2 { get; private set; }
        public PlaceType SmallTable { get; private set; }
        public PlaceType MediumTable { get; private set; }
        public Reservation Reservation1 { get; private set; }
        public Reservation Reservation2 { get; private set; }
        public ReservationPlace ReservationPlace1 { get; private set; }
        public ReservationPlace ReservationPlace2 { get; private set; }

        private void SeedDatabase()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            AppUser1 = new ApplicationUser
            {
                Id = "1b572cdb-ca30-43a0-8718-12df99d66c45",
                UserName = "user@mail.com",
                NormalizedUserName = "user@mail.com",
                Email = "user@mail.com",
                NormalizedEmail = "user@mail.com",
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "0898888888"
            };
            AppUser1.PasswordHash = hasher.HashPassword(AppUser1, "123456z");
            context.ApplicationUsers.AddAsync(AppUser1);

            AppUser2 = new ApplicationUser
            {
                Id = "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                FirstName = "Zahary",
                LastName = "Nyagolov",
                PhoneNumber = "0888888888"
            };
            AppUser2.PasswordHash = hasher.HashPassword(AppUser2, "123456z");
            context.ApplicationUsers.AddAsync(AppUser2);

            Dune = new Boardgame()
            {
                Id = 1,
                Name = "Dune: Imperium",
                AppropriateAge = 14,
                AveragePlayingTime = 90,
                Rating = 3,
                Description = "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.",
                Difficulty = 3,
                CardImageUrl = "/assets/games/Dune_Imperium_card.jpg",
                DetailsImageUrl = "/assets/games/Dune_Imperium_details.jpg",
                YearPublished = 2020,
                PriceInShop = 90.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };
            context.Boardgames.AddAsync(Dune);

            TerraformMars = new Boardgame()
            {
                Id = 2,
                Name = "Terraforming Mars",
                AppropriateAge = 12,
                AveragePlayingTime = 120,
                Rating = 5,
                Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                Difficulty = 3.5,
                CardImageUrl = "/assets/games/Terraforming_Mars_card.jpg",
                DetailsImageUrl = "/assets/games/Terraforming_Mars_details.jpg",
                YearPublished = 2016,
                PriceInShop = 100.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };
            context.Boardgames.AddAsync(TerraformMars);

            Category1 = new Category()
            {
                Id = 1,
                Name = "Animals",
            };
            context.Categories.AddAsync(Category1);

            Category2 = new Category()
            {
                Id = 2,
                Name = "Economy"
            };
            context.Categories.AddAsync(Category2);

            Category3 = new Category()
            {
                Id = 3,
                Name = "Industry"
            };
            context.Categories.AddAsync(Category3);

            DuneCategory1 = new BoardgameCategory()
            {
                BoardgameId = 1,
                CategoryId = 3
            };
            context.BoardgamesCategories.AddAsync(DuneCategory1);

            DuneCategory2 = new BoardgameCategory()
            {
                BoardgameId = 1,
                CategoryId = 2
            };
            context.BoardgamesCategories.AddAsync(DuneCategory2);

            TerraformMarsCategory1 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 1
            };
            context.BoardgamesCategories.AddAsync(TerraformMarsCategory1);

            TerraformMarsCategory2 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 2
            };
            context.BoardgamesCategories.AddAsync(TerraformMarsCategory2);

            TerraformMarsCategory3 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 3
            };
            context.BoardgamesCategories.AddAsync(TerraformMarsCategory3);

            GameReview1 = new GameReview()
            {
                Id = 1,
                ReviewText = "Not that good game!",
                Date = DateTime.Now.ToString("dd-MM-yyyy HH:mm"),
                Boardgame = Dune,
                BoardGameId = 1,
                ReviewOwner = AppUser1,
                ReviewOwnerId = "1b572cdb-ca30-43a0-8718-12df99d66c45"
            };
            context.GameReviews.AddAsync(GameReview1);

            GameReview2 = new GameReview()
            {
                Id = 2,
                ReviewText = "Best game!",
                Date = DateTime.Now.ToString("dd-MM-yyyy HH:mm"),
                Boardgame = TerraformMars,
                BoardGameId = 2,
                ReviewOwner = AppUser2,
                ReviewOwnerId = "014d16f4-b47d-45fa-98a5-0cb40aa950c5"
            };
            context.GameReviews.AddAsync(GameReview2);

            SmallTable = new PlaceType()
            {
                Id = 1,
                Name = "Small table",
                Capacity = 2,
                PricePerHour = 10.00M
            };
            context.PlaceTypes.Add(SmallTable);

            MediumTable = new PlaceType()
            {
                Id = 2,
                Name = "Medium table",
                Capacity = 4,
                PricePerHour = 20.00M
            };
            context.PlaceTypes.Add(MediumTable);

            ReservationPlace1 = new ReservationPlace()
            {
                Id = 1,
                Name = "Table for 2 - No1",
                PlaceTypeId = 1,
                IsReserved = false,
            };
            context.ReservationPlaces.AddAsync(ReservationPlace1);

            ReservationPlace2 = new ReservationPlace()
            {
                Id = 2,
                Name = "Table for 4 - No1",
                PlaceTypeId = 2,
                IsReserved = false,
            };
            context.ReservationPlaces.AddAsync(ReservationPlace2);

            Reservation1 = new Reservation()
            {
                Id = 1,
                ReservationOwner = AppUser1,
                ReservationOwnerId = "1b572cdb-ca30-43a0-8718-12df99d66c45",
                DateTime = DateTime.Now,
                AdditionalComment = null,
                PhoneNumber = "0896778522",
                ReservationPlace = ReservationPlace1,
                ReservationPlaceId = 1,
                BoardgameReservedId = 1,
                BoardgameReserved = Dune,
                IsExpired = false
            };
            context.Reservations.AddAsync(Reservation1);

            Reservation2 = new Reservation()
            {
                Id = 2,
                ReservationOwner = AppUser2,
                ReservationOwnerId = "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                DateTime = DateTime.Now,
                AdditionalComment = "I would like a place near the window.",
                PhoneNumber = "0896778552",
                ReservationPlace = ReservationPlace2,
                ReservationPlaceId = 2,
                BoardgameReservedId = 2,
                BoardgameReserved = TerraformMars,
                IsExpired = false
            };
            context.Reservations.AddAsync(Reservation2);
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
