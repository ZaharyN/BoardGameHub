using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                data.DuneGenre1,
                data.DuneGenre2,
                data.DuneGenre3,

                data.TerraformMarsGenre1,
                data.TerraformMarsGenre2,
                data.TerraformMarsGenre3,

                data.CatanGenre1,
                data.CatanGenre2,

                data.PhotosynthesisGenre1,
                data.PhotosynthesisGenre2,

                data.TicketToRideGenre,

                data.GloomhavenGenre1,
                data.GloomhavenGenre2,
                data.GloomhavenGenre3,
                data.GloomhavenGenre4,

                data.MysteriumGenre1,
                data.MysteriumGenre2,
                data.MysteriumGenre3,

                data.EverdellGenre1,
                data.EverdellGenre2,
                data.EverdellGenre3,

                data.MonopolyBulgariaGenre1,
                data.MonopolyBulgariaGenre2,

                data.PandemicGenre1,
                data.PandemicGenre2
            });
        }
    }
}
