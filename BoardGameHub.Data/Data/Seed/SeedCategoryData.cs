using BoardGameHub.Data.Data.DataModels;
using System.Reflection.Metadata.Ecma335;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedCategoryData
    {
        public SeedCategoryData()
        {
            SeedCategories();
        }

        public Category AbstractStrategyCategory { get; set; }
        public Category AdventureCategory { get; set; }
        public Category DeductionCategory { get; set; }
        public Category DexterityCategory { get; set; }
        public Category FamilyCategory { get; set; }
        public Category ExplorationCategory { get; set; }
        public Category HorrorCategory { get; set; }
        public Category IndustryCategory { get; set; }
        public Category TerritoryBuildingCategory { get; set; }
        public Category EconomicCategory { get; set; }
        public Category PuzzleCategory { get; set; }
        public Category DeckbuilderCategory { get; set; }
        public Category PlacementCategory { get; set; }
        public Category CooperativeCategory { get; set; }
        public Category CombatCategory { get; set; }
        public Category PartyCategory { get; set; }
        public Category StrategyCategory { get; set; }
        public Category NegotiationCategory { get; set; }
        public Category TrainsCategory { get; set; }
        public Category AnimalsCategory { get; set; }
        public Category CardGameCategory { get; set; }
        public Category EnvironmentalCategory { get; set; }
        public Category EducationalCategory { get; set; }
        public Category CivilizationCategory { get; set; }


        private void SeedCategories()
        {

            AbstractStrategyCategory = new Category()
            {
                Id = 1,
                Name = "Abstract",
            };

            AdventureCategory = new Category()
            {
                Id = 2,
                Name = "Adventure"
            };

            DeductionCategory = new Category()
            {
                Id = 3,
                Name = "Deduction"
            };

            DexterityCategory = new Category()
            {
                Id = 4,
                Name = "Dexterity"
            };

            FamilyCategory = new Category()
            {
                Id = 5,
                Name = "Family"
            };

            ExplorationCategory = new Category()
            {
                Id = 6,
                Name = "Exploration"
            };

            HorrorCategory = new Category()
            {
                Id = 7,
                Name = "Horror"
            };

            IndustryCategory = new Category()
            {
                Id = 8,
                Name = "Industry"
            };

            TerritoryBuildingCategory = new Category()
            {
                Id = 9,
                Name = "Territory building"
            };

            EconomicCategory = new Category()
            {
                Id = 10,
                Name = "Economy"
            };

            PuzzleCategory = new Category()
            {
                Id = 11,
                Name = "Puzzle"
            };

            DeckbuilderCategory = new Category()
            {
                Id = 12,
                Name = "Deckbuilder"
            };

            PlacementCategory = new Category()
            {
                Id = 13,
                Name = "Placement"
            };

            CooperativeCategory = new Category()
            {
                Id = 14,
                Name = "Cooperative"
            };

            CombatCategory = new Category()
            {
                Id = 15,
                Name = "Combat"
            };

            PartyCategory = new Category()
            {
                Id = 16,
                Name = "Party"
            };

            StrategyCategory = new Category()
            {
                Id = 17,
                Name = "Strategy"
            };

            NegotiationCategory = new Category()
            {
                Id = 18,
                Name = "Negotiation"
            };

            TrainsCategory = new Category()
            {
                Id = 19,
                Name = "Trains"
            };

            AnimalsCategory = new Category()
            {
                Id = 20,
                Name = "Animals"
            };

            CardGameCategory = new Category()
            {
                Id = 21,
                Name = "Card game"
            };

            EnvironmentalCategory = new Category()
            {
                Id = 22,
                Name = "Environmental"
            };

            EducationalCategory = new Category()
            {
                Id = 23,
                Name = "Educational"
            };

            CivilizationCategory = new Category()
            {
                Id = 24,
                Name = "Civilization"
            };
        }
    }
}
