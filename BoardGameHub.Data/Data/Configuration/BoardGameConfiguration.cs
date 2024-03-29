using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class BoardgameConfiguration : IEntityTypeConfiguration<Boardgame>
    {
        public void Configure(EntityTypeBuilder<Boardgame> builder)
        {
            SeedBoardgameData data = new SeedBoardgameData();

            builder.HasData(new Boardgame[]
            {
                data.DuneBoardgame,
                data.TerraformingMarsBoardgame,
                data.CatanBoardgame,
                data.PhotosynthesisBoardgame,
                data.TicketToRideBoardgame
            });
        }
    }
}
