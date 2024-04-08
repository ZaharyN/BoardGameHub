using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class BoardgameCategoryConfiguration : IEntityTypeConfiguration<BoardgameCategory>
    {
        public void Configure(EntityTypeBuilder<BoardgameCategory> builder)
        {
            SeedBoardgameCategoryData data = new SeedBoardgameCategoryData();

            builder
                .HasKey(bg => new
                {
                    bg.BoardgameId,
                    bg.CategoryId
                });

            builder.HasData(new BoardgameCategory[]
            {
                data.DuneCategory1,
                data.DuneCategory2,
                data.DuneCategory3,

                data.TerraformMarsCategory1,
                data.TerraformMarsCategory2,
                data.TerraformMarsCategory3,

                data.CatanCategory1,
                data.CatanCategory2,

                data.PhotosynthesisCategory1,
                data.PhotosynthesisCategory2,

                data.TicketToRideCategory,

                data.GloomhavenCategory1,
                data.GloomhavenCategory2,
                data.GloomhavenCategory3,
                data.GloomhavenCategory4,

                data.MysteriumCategory1,
                data.MysteriumCategory2,
                data.MysteriumCategory3,

                data.EverdellCategory1,
                data.EverdellCategory2,
                data.EverdellCategory3,

                data.MonopolyBulgariaCategory1,
                data.MonopolyBulgariaCategory2,

                data.PandemicCategory1,
                data.PandemicCategory2,

                data.BrassBirminghamCategory1,
                data.BrassBirminghamCategory2,
                data.BrassBirminghamCategory3,
                
                data.ArkNovaCategory1,
                data.ArkNovaCategory2,
                data.ArkNovaCategory3,
                
                data.ScytheCategory1,
                data.ScytheCategory2,
                
                data.NemesisCategory1,
                data.NemesisCategory2,
                data.NemesisCategory3,
                
                data.WingspanCategory1,
                data.WingspanCategory2,
                data.WingspanCategory3,
                
                data.CascadiaCategory1,
                data.CascadiaCategory2,
                data.CascadiaCategory3,
                
                data.CodenamesCategory1,
                data.CodenamesCategory2,
                data.CodenamesCategory3,
                
                data.DixitCategory1,
                data.DixitCategory2,
                
                data.ExplodingKittensCategory1,
                data.ExplodingKittensCategory2,
                
                data.DecryptoCategory1,
                data.DecryptoCategory2,
                
                data.EclipseCategory1,
                data.EclipseCategory2
            });
        }
    }
}
