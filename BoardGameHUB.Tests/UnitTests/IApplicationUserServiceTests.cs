using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;

namespace BoardGameHUB.Tests.UnitTests
{
    [TestFixture]
    public class IApplicationUserServiceTests : UnitTestsBase
    {
        private IApplicationUserService applicationUserService;

        [OneTimeSetUp]
        public void SetUp() => applicationUserService = new ApplicationUserService(context);

        [Test]
        public async Task UserFullNameShouldWorkProperly()
        {
            string validId = AppUser1.Id;

            string fullName = await applicationUserService.UserFullName(validId);

            Assert.AreEqual(fullName, $"{AppUser1.FirstName} {AppUser1.LastName}");
        }

        [Test]
        public async Task UserFullNameShouldReturnNullIfUserHasNoName()
        {
            AppUser1.FirstName = string.Empty;

            var result1 = await applicationUserService.UserFullName(AppUser1.Id);

            Assert.IsNull(result1);

            AppUser1.FirstName = "Ivan";
            AppUser1.LastName = null;
            var result2 = await applicationUserService.UserFullName(AppUser1.Id);

            Assert.IsNull(result2);
        }
    }
}
