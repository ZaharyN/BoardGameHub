using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHUB.Tests.UnitTests
{
    [TestFixture]
    public class ReservationServiceTests : UnitTestsBase
    {
        private IReservationService reservationService;

        [OneTimeSetUp]
        public void SetUp() => reservationService = new ReservationService(context);

    }
}
