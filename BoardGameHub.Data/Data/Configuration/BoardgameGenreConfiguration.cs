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
    internal class BoardgameGenreConfiguration : IEntityTypeConfiguration<BoardgameGenre>
    {
        public void Configure(EntityTypeBuilder<BoardgameGenre> builder)
        {
            SeedBoardgameGenreData data = new SeedBoardgameGenreData();

            builder
                .HasKey(bg => new
                {
                    bg.BoardgameId,
                    bg.GenreId
                });

            builder.HasData(new BoardgameGenre[]
            {
                data.DuneGenre1
            });
        }
    }
}
