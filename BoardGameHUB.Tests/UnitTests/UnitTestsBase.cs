using AutoMapper;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using BoardGameHUB.Tests.Mocks;
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
        public Boardgame Boardgame1 { get; private set; }
        public Boardgame Boardgame2 { get; private set; }
        public BoardgameCategory BoardgameCategory1 { get; private set; }
        public BoardgameCategory BoardgameCategory2 { get; private set; }
        public Category Category1 { get; private set; }
        public Category Category2 { get; private set; }
        public GameReview GameReview1 { get; private set; }
        public GameReview GameReview2 { get; private set; }
        public PlaceType PlaceType1 { get; private set; }
        public PlaceType PlaceType2 { get; private set; }
        public Reservation Reservation1 { get; private set; }
        public Reservation Reservation2 { get; private set; }
        public ReservationPlace ReservationPlace1 { get; private set; }
        public ReservationPlace ReservationPlace2 { get; private set; }

        private void SeedDatabase()
        {
            AppUser1 = new ApplicationUser
            {

            };

            AppUser2 = new ApplicationUser
            {

            };
        }
    }
}
