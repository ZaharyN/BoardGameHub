using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
