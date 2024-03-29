using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class BoardGameConfiguration : IEntityTypeConfiguration<Boardgame>
    {
        public void Configure(EntityTypeBuilder<Boardgame> builder)
        {
            SeedBoardGameData seedBoardGameData = new SeedBoardGameData();

            builder.HasData(new Boardgame[]
            {
                seedBoardGameData.DuneBoardgame
            });
        }
    }
}
