using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Data.Data
{
    public class BoardGameHubDbContext : IdentityDbContext
    {
        public BoardGameHubDbContext(DbContextOptions<BoardGameHubDbContext> options)
            : base(options)
        {
            
        }
    }
}
