using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
