using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            SeedCategoryData data = new SeedCategoryData();

            builder.HasData(new Category[]
            {
                data.AbstractStrategyCategory,
                data.AdventureCategory,
                data.DeductionCategory,
                data.DexterityCategory,
                data.FamilyCategory,
                data.ExplorationCategory,
                data.HorrorCategory,
                data.IndustryCategory,
                data.TerritoryBuildingCategory,
                data.EconomicCategory,
                data.PuzzleCategory,
                data.DeckbuilderCategory,
                data.PlacementCategory,
                data.CooperativeCategory,
                data.CombatCategory,
                data.PartyCategory,
                data.StrategyCategory,
                data.NegotiationCategory,
                data.TrainsCategory,
                data.AnimalsCategory,
                data.CardGameCategory,
                data.EnvironmentalCategory,
                data.EducationalCategory,
                data.CivilizationCategory
            });
        }
    }
}
