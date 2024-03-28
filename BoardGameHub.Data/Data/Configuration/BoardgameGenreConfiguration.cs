using BoardGameHub.Data.Data.DataModels;
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
            builder
                .HasKey(bg => new
                {
                    bg.BoardgameId,
                    bg.GenreId
                });
        }
    }
}
