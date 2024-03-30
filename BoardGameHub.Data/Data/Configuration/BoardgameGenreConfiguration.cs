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
                data.PandemicGenre2,

                data.BrassBirminghamGenre1,
                data.BrassBirminghamGenre2,
                data.BrassBirminghamGenre3,
                
                data.ArkNovaGenre1,
                data.ArkNovaGenre2,
                data.ArkNovaGenre3,
                
                data.ScytheGenre1,
                data.ScytheGenre2,
                
                data.NemesisGenre1,
                data.NemesisGenre2,
                data.NemesisGenre3,
                
                data.WingspanGenre1,
                data.WingspanGenre2,
                data.WingspanGenre3,
                
                data.CascadiaGenre1,
                data.CascadiaGenre2,
                data.CascadiaGenre3,
                
                data.CodenamesGenre1,
                data.CodenamesGenre2,
                data.CodenamesGenre3,
                
                data.DixitGenre1,
                data.DixitGenre2,
                
                data.ExplodingKittensGenre1,
                data.ExplodingKittensGenre2,
                
                data.DecryptoGenre1,
                data.DecryptoGenre2,
                
                data.EclipseGenre1,
                data.EclipseGenre2
            });
        }
    }
}
