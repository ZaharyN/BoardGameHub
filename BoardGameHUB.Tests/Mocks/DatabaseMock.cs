using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHUB.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static BoardGameHubDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<BoardGameHubDbContext>()
                    .UseInMemoryDatabase("BoardGameHubInMemoryDb" + DateTime.Now.Ticks.ToString())
                    .Options;

                return new BoardGameHubDbContext(dbContextOptions, false);
            }
        }

    }
}
