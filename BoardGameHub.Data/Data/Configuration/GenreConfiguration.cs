using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            SeedGenreData data = new SeedGenreData();

            builder.HasData(new Genre[]
            {
                data.AbstractStrategyGenre,
                data.AdventureGenre,
                data.DeductionGenre,
                data.DexterityGenre,
                data.FamilyGenre,
                data.ExplorationGenre,
                data.HorrorGenre,
                data.IndustryGenre,
                data.TerritoryBuildingGenre,
                data.EconomicGenre,
                data.PuzzleGenre,
                data.DeckbuilderGenre,
                data.PlacementGenre,
                data.CooperativeGenre,
                data.CombatGenre,
                data.PartyGenre,
                data.StrategyGenre,
                data.NegotiationGenre,
                data.TrainsGenre
            });
        }
    }
}
